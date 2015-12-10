<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H3340_T3.aspx.cs" Inherits="H3340_T3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>PuolipilkunViilaajat</h1>
    <img src="kuvat/kuva.jpg" alt="It-aiheinen kuva"/>
    <br />

        <asp:Label ID="lblNimi" runat="server" Text="Nimi: "></asp:Label><asp:TextBox ID="tbNimi" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSalasana" runat="server" Text="Salasana :"></asp:Label><asp:TextBox ID="tbSalasana" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnKirjaudu" runat="server" Text="Kirjaudu" OnClick="btnKirjaudu_Click" />
    </div>



        <br />
        <br />
        <br />
        <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
