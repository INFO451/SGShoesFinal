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
            <asp:ObjectDataSource ID="CatSDS" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.Category" DeleteMethod="deleteCategory" InsertMethod="insertCategory" SelectMethod="getAllCategories" TypeName="SGShoesFinal.App_Code.Category" UpdateMethod="updateCategory"></asp:ObjectDataSource>
            <asp:GridView ID="CatGrid" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="CatSDS">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="CatId" HeaderText="CatId" SortExpression="CatId" />
                    <asp:BoundField DataField="CatName" HeaderText="CatName" SortExpression="CatName" />
                    <asp:BoundField DataField="CatDescription" HeaderText="CatDescription" SortExpression="CatDescription" />
                </Columns>
            </asp:GridView>
        </asp:View>
        <asp:View ID="CustView" runat="server">
            <asp:ObjectDataSource ID="CustSDS" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.Customer" DeleteMethod="deleteCustomer" InsertMethod="insertCustomer" SelectMethod="getAllCustomers" TypeName="SGShoesFinal.App_Code.Customer" UpdateMethod="updateCustomer"></asp:ObjectDataSource>
            <asp:GridView ID="CustGrid" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="CatSDS">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="CatId" HeaderText="CatId" SortExpression="CatId" />
                    <asp:BoundField DataField="CatName" HeaderText="CatName" SortExpression="CatName" />
                    <asp:BoundField DataField="CatDescription" HeaderText="CatDescription" SortExpression="CatDescription" />
                </Columns>
            </asp:GridView>
        </asp:View>
        <asp:View ID="OrderView" runat="server">
            <asp:ObjectDataSource ID="OrderSDS" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.Order" DeleteMethod="deleteOrder" InsertMethod="insertOrder" SelectMethod="getAllOrders" TypeName="SGShoesFinal.App_Code.Order" UpdateMethod="updateOrder"></asp:ObjectDataSource>
            <asp:GridView ID="OrderGrid" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="OrderSDS">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="OrderId" HeaderText="OrderId" SortExpression="OrderId" />
                    <asp:BoundField DataField="CustId" HeaderText="CustId" SortExpression="CustId" />
                    <asp:BoundField DataField="ProdId" HeaderText="ProdId" SortExpression="ProdId" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:BoundField DataField="SaleDate" HeaderText="SaleDate" SortExpression="SaleDate" />
                    <asp:BoundField DataField="OrderStatus" HeaderText="OrderStatus" SortExpression="OrderStatus" />
                </Columns>
            </asp:GridView>
        </asp:View>
        <asp:View ID="ProdView" runat="server">
            <asp:ObjectDataSource ID="ProdSDS" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.Product" DeleteMethod="deleteProduct" InsertMethod="insertProduct" SelectMethod="getAllProducts" TypeName="SGShoesFinal.App_Code.Product" UpdateMethod="updateProduct"></asp:ObjectDataSource>
            <asp:GridView ID="ProdGrid" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ProdSDS">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="CatId" HeaderText="CatId" SortExpression="CatId" />
                    <asp:BoundField DataField="ProdName" HeaderText="ProdName" SortExpression="ProdName" />
                    <asp:BoundField DataField="Manfac" HeaderText="Manfac" SortExpression="Manfac" />
                    <asp:BoundField DataField="ShortDescrip" HeaderText="ShortDescrip" SortExpression="ShortDescrip" />
                    <asp:BoundField DataField="LongDescrip" HeaderText="LongDescrip" SortExpression="LongDescrip" />
                    <asp:BoundField DataField="UnitWeight" HeaderText="UnitWeight" SortExpression="UnitWeight" />
                    <asp:BoundField DataField="unitPrice" HeaderText="unitPrice" SortExpression="unitPrice" />
                    <asp:BoundField DataField="Keywords" HeaderText="Keywords" SortExpression="Keywords" />
                    <asp:BoundField DataField="ImageLocSmall" HeaderText="ImageLocSmall" SortExpression="ImageLocSmall" />
                    <asp:BoundField DataField="ImageLocLarge" HeaderText="ImageLocLarge" SortExpression="ImageLocLarge" />
                </Columns>
            </asp:GridView>
        </asp:View>
        <asp:View ID="ProdDetailView" runat="server">
            <asp:ObjectDataSource ID="ProdDetailSDS" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.Product_Detail" DeleteMethod="deleteProductDet" InsertMethod="insertProductDet" SelectMethod="getAllProductDets" TypeName="SGShoesFinal.App_Code.Product_Detail" UpdateMethod="updateProductDet"></asp:ObjectDataSource>
            <asp:GridView ID="ProdDetailGrid" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ProdDetailSDS">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="ProdId" HeaderText="ProdId" SortExpression="ProdId" />
                    <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>
            </asp:GridView>
        </asp:View>
    </asp:MultiView>
        </div>
</asp:Content>
