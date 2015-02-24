<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox ID="txtLast" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>first Name</td>
            <td>
                <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email (user name)</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Street</td>
            <td>
                <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Apartment</td>
            <td>
                <asp:TextBox ID="txtApartment" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>City</td>
            <td>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>State</td>
            <td>
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Zip code</td>
            <td>
                <asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
            <td>
                <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>   </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
