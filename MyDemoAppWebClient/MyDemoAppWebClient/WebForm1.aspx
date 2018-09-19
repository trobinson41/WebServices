<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyDemoAppWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            N1: <asp:TextBox ID="txtN1" runat="server"></asp:TextBox><br />
            N2: <asp:TextBox ID="txtN2" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />&nbsp;
            <asp:Button ID="btnSub" runat="server" Text="Subtract" OnClick="btnSub_Click" />
            &nbsp;
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
