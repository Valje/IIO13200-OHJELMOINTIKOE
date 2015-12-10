<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sisalla.aspx.cs" Inherits="sisalla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblNimi" runat="server" Text="Nimi :"></asp:Label>
        <asp:TextBox ID="tbNimi" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPVM" runat="server" Text="Nimi :"></asp:Label>
        <asp:TextBox ID="tbPVM" type="date" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblTunnit" runat="server" Text="Nimi :"></asp:Label>
        <asp:TextBox ID="tbTunnit" runat="server"></asp:TextBox>

        <br />

        <asp:Button ID="btnKirjaa" runat="server" Text="Kirjaa tunnit" OnClick="btnKirjaa_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnLogOut" runat="server" Text="Ulos" OnClick="btnLogOut_Click" />
    
    </div>
    </form>
</body>
</html>
