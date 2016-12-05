<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SGShoesFinal.Masters.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="center-block"><h2>Welcome to S&G Shoes!</h2>
    <h3>Browse or Login</h3>
    <h3>Start Shopping!<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fall16_g2ConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="Category_Id" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                Category_Id:
                <asp:Label ID="Category_IdLabel" runat="server" Text='<%# Eval("Category_Id") %>' />
                <br />
                Category_Name:
                <asp:Label ID="Category_NameLabel" runat="server" Text='<%# Eval("Category_Name") %>' />
                <br />
                Category_Description:
                <asp:Label ID="Category_DescriptionLabel" runat="server" Text='<%# Eval("Category_Description") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
    </h3>
    </div>
</asp:Content>
