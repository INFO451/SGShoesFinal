<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Masters/Main.Master" CodeBehind="Myaccount.aspx.cs" Inherits="SGShoesFinal.Myaccount" %>

<asp:Content  ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        <asp:ObjectDataSource ID="CustomerDataSource" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.Customer" DeleteMethod="deleteCustomer" InsertMethod="insertCustomer" SelectMethod="getAllCustomers" TypeName="SGShoesFinal.App_Code.Customer" UpdateMethod="updateCustomer"></asp:ObjectDataSource>
        <asp:SqlDataSource ID="OrderDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:fall16_g2ConnectionString %>" SelectCommand="SELECT * FROM [Order] WHERE ([Customer_Id] = @Customer_Id)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="Customer_Id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </h2>
        <h2>Account Information</h2>
        <h4>Login</h4>
        <h4>First Name</h4>
        <h4>Last Name</h4>
        <h4>Phone Number</h4>
        <h4>Email</h4>
    <h2>Checkout Settings</h2>
        <h4>Shipping Address</h4>
        <h4>Billing Address</h4>
        <h4>Credit Card</h4>
    <h2>Order Status</h2>
        <h4>Order ID</h4>
        <h4>Order Date</h4>
        <h4>Order Status</h4>
    </asp:Content>
