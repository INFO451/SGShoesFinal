<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Myaccount.aspx.cs" Inherits="SGShoesFinal.Myaccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Profile</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
        </h2>
        <h2>Account Information</h2>
        <h4>First Name</h4>
        <h4>Last Name</h4>
    <h2>Checkout Settings</h2>
        <h4>Shipping Address</h4>
        <h4>Billing Address</h4>
        <h4>Credit Card</h4>
    <h2>Order Status</h2>
        <h4>Order ID</h4>
        <h4>Order Date</h4>
        <h4>Order Status</h4>
    </div>
    </form>
</body>
</html>
