# ==============================================================================
# Script: Detect-LocalServer32Hijack.ps1
# Description: Scans Registry for LocalServer32 keys pointing to non-existent binaries.
# Author: Professional Security Assessment Tool
# ==============================================================================

# Define the Registry paths to scan
$PathsToScan = @(
    "Registry::HKEY_CURRENT_USER\Software\Classes\CLSID",
    "Registry::HKEY_LOCAL_MACHINE\Software\Classes\CLSID",
    "Registry::HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID"
)

$VulnerableEntries = [System.Collections.Generic.List[PSObject]]::new()

Write-Host "[*] Starting LocalServer32 Hijacking Scan..." -ForegroundColor Cyan
Write-Host "[*] This may take a minute depending on your registry size..." -ForegroundColor Yellow

foreach ($RootPath in $PathsToScan) {
    if (-not (Test-Path $RootPath)) {
        continue
    }

    # Get all CLSID subkeys
    $clsids = Get-ChildItem -Path $RootPath -ErrorAction SilentlyContinue

    foreach ($clsid in $clsids) {
        $localServer32Path = Join-Path $clsid.PSPath "LocalServer32"
        
        if (Test-Path $localServer32Path) {
            # Get the Default value of the LocalServer32 key
            $defaultValue = (Get-ItemProperty -Path $localServer32Path -Name "(default)" -ErrorAction SilentlyContinue)."(default)"

            if ($defaultValue) {
                # Clean the path: Remove arguments and quotes
                $cleanPath = $defaultValue.Trim()
                
                # Regex to extract the actual executable path
                if ($cleanPath -match '^"([^"]+)"') {
                    $cleanPath = $Matches[1]
                } elseif ($cleanPath -match '^([^\s]+)') {
                    # Fallback for unquoted paths with spaces (common source of hijacking)
                    $cleanPath = $Matches[1]
                }

                # Resolve environment variables like %SystemRoot%, %ProgramFiles%, etc.
                $expandedPath = [System.Environment]::ExpandEnvironmentVariables($cleanPath)

                # Check if the extracted path looks like an executable
                if ($expandedPath -like "*.exe" -or $expandedPath -like "*.com") {
                    
                    # If the file does NOT exist, it is highly vulnerable to Hijacking
                    if (-not (Test-Path $expandedPath -ErrorAction SilentlyContinue)) {
                        
                        $VulnerableEntries.Add([PSCustomObject]@{
                            "CLSID"         = $clsid.PSChildName
                            "RegistryHive"  = $RootPath.Split('\')[0]
                            "RegistryPath"  = $localServer32Path
                            "OriginalValue" = $defaultValue
                            "ExtractedPath" = $expandedPath
                            "Status"        = "Vulnerable (Missing Binary)"
                        })
                    }
                }
            }
        }
    }
}

# --- Output Results ---
if ($VulnerableEntries.Count -gt 0) {
    Write-Host "`n[!] Found $($VulnerableEntries.Count) potentially hijackable LocalServer32 entries:" -ForegroundColor Red
    
    # Display in a clean Table format
    $VulnerableEntries | Format-Table -Property RegistryHive, CLSID, ExtractedPath -AutoSize
    
    # Optional: Open in a GUI grid for easier filtering
    $VulnerableEntries | Out-GridView -Title "Vulnerable LocalServer32 Hijacking Candidates"
} else {
    Write-Host "`n[+] Scan completed. No vulnerable LocalServer32 entries found." -ForegroundColor Green
}
