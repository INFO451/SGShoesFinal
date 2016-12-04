<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedInPages/PagesAdmin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminControls.aspx.cs" Inherits="SGShoesFinal.LoggedInPages.PagesAdmin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="AdminMenu" 
        runat="server" 
        Orientation="Horizontal"
        StaticMenuItemStyle-CssClass="tab"
        StaticSelectedStyle-CssClass="selectedTab"
        CssClass="tabs"
        OnMenuItemClick="AdminMenu_MenuItemClick"
        >
        <Items>
            <asp:MenuItem Text="Categories" Value="0" Selected="true" />
            <asp:MenuItem Text="Customers" Value="1"/>
            <asp:MenuItem Text="Orders" Value="2" />
            <asp:MenuItem Text="Products" Value="3"/>
            <asp:MenuItem Text="Product Details" Value="4" />
        </Items>
    </asp:Menu>
    <div class="tabContents">
    <asp:MultiView ID="AdminMV" ActiveViewIndex="0" runat="server">
        <asp:View ID="CatView" runat="server">
            <asp:SqlDataSource ID="CatSDS" runat="server"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </asp:View>
        <asp:View ID="CustView" runat="server">
            <asp:SqlDataSource ID="CustSDS" runat="server"></asp:SqlDataSource>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </asp:View>
        <asp:View ID="OrderView" runat="server">
            <asp:SqlDataSource ID="OrderSDS" runat="server"></asp:SqlDataSource>
            <asp:GridView ID="GridView3" runat="server"></asp:GridView>
        </asp:View>
        <asp:View ID="ProdView" runat="server">
            <asp:SqlDataSource ID="ProdSDS" runat="server"></asp:SqlDataSource>
            <asp:GridView ID="GridView4" runat="server"></asp:GridView>
        </asp:View>
        <asp:View ID="ProdDetailView" runat="server">
            <asp:SqlDataSource ID="ProdDetailSDS" runat="server"></asp:SqlDataSource>
            <asp:GridView ID="GridView5" runat="server"></asp:GridView>
        </asp:View>
    </asp:MultiView>
        </div>
</asp:Content>
