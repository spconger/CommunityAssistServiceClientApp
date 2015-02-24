<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donation.aspx.cs" Inherits="Donation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>donation</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Please enter the amount you wish to donate. Be Very generous</p>
        <p>
            <asp:TextBox ID="txtDonation" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="btnDonation" runat="server" Text="give" OnClick="btnDonation_Click" /></p>
        <p>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></p>
    </div>
    </form>
</body>
</html>
