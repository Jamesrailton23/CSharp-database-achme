<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="database_achme._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="resultLable" runat="server"></asp:Label>
        </div>
        <asp:GridView ID="customer_gridview" runat="server">
        </asp:GridView>
        <p>
            name -
            <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
        </p>
        <p>
            address -
            <asp:TextBox ID="tb_addr" runat="server"></asp:TextBox>
        </p>
        <p>
            city -
            <asp:TextBox ID="tb_city" runat="server"></asp:TextBox>
        </p>
        <p>
            postcode -
            <asp:TextBox ID="tb_pcode" runat="server"></asp:TextBox>
        </p>
        <p>
            notes -
            <asp:TextBox ID="tb_notes" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="buttonSave" runat="server" OnClick="buttonSave_Click" Text="Button" />
    </form>
</body>
</html>
