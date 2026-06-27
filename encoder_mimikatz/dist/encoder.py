# Encoder.py
input_path = "loader.b64"
output_path = "encoded.xor"
result = ""

with open(input_path, 'r', encoding='utf-8') as fp:
    for line in fp:
        for char in line:
            xor_val = ord(char) ^ 5
            result += f"{xor_val:03d}"

with open(output_path, 'w', encoding='utf-8') as xor_file:
    xor_file.write(result)
