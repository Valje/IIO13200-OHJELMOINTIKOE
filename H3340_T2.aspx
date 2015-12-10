<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H3340_T2.aspx.cs" Inherits="H3340_T2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnVakkarit" runat="server" Text="Näytä vakituiset" OnClick="btnVakkarit_Click" />
        <asp:Button ID="btnMaaraaikaiset" runat="server" Text="Näytä määräaikaiset" OnClick="btnMaaraaikaiset_Click" />
        <asp:Button ID="btnMuut" runat="server" Text="Näytä muut" OnClick="btnMuut_Click" />
        <asp:Button ID="btnKaikki" runat="server" Text="Näytä kaikki" OnClick="btnKaikki_Click" />

        <br />
        <br />
        <br />

        <asp:GridView ID="gridTyontekijat" runat="server"></asp:GridView>
        <br />
        <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
