<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="SGShoesFinal.Masters.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <aside class="col-md-3">
        <h2 class="refine">REFINE BY</h2>
        <div class="panel">
            <ul class="section">
                <li>Flats</li>
                <li>Sandles</li>
                <li>Boots</li>
                <li>Heels</li>
            </ul></div>
        <div class="panel">
            <ul class="section">
                <li>Test</li>
            </ul>
        </div>
    </aside>
    <div class="col-md-9">
    <asp:ObjectDataSource ID="ProductData" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.Product" DeleteMethod="deleteProduct" InsertMethod="insertProduct" SelectMethod="getAllProducts" TypeName="SGShoesFinal.App_Code.Product" UpdateMethod="updateProduct"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="DetailDataSource" runat="server"></asp:ObjectDataSource>
<asp:DataList ID="DataList1" runat="server" DataSourceID="ProductData" RepeatColumns="3">
    <ItemTemplate>
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageLocSmall") %>' />
        <br />
        ProdName:
        <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProdName") %>' />
        <br />
        Manfac:
        <asp:Label ID="ManfacLabel" runat="server" Text='<%# Eval("Manfac") %>' />
        <br />
        ShortDescrip:
        <asp:Label ID="ShortDescripLabel" runat="server" Text='<%# Eval("ShortDescrip") %>' />
        <br />
        unitPrice:
        <asp:Label ID="unitPriceLabel" runat="server" Text='<%# Eval("unitPrice") %>' />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
        </asp:DropDownList>
<br />
    </ItemTemplate>
</asp:DataList>
</div>
</asp:Content>

