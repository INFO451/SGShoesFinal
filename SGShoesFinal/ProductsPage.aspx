<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="SGShoesFinal.Masters.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <aside class="col-md-3">
        <h2 class="refine">REFINE BY</h2>
        <div class="category">
            <ul class="section">Category
                <li>Test</li>
            </ul>
            <ul class="section">Size
                <li>Test</li>
            </ul>
        </div>
    </aside>
    <div class="col-md-9">
    <asp:ObjectDataSource ID="ProductData" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.Product" DeleteMethod="deleteProduct" InsertMethod="insertProduct" SelectMethod="getAllProducts" TypeName="SGShoesFinal.App_Code.BusinessLogic" UpdateMethod="updateProduct"></asp:ObjectDataSource>
<asp:DataList ID="DataList1" runat="server" DataSourceID="ProductData" RepeatColumns="2">
    <ItemTemplate>
&nbsp;<asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProdName") %>' Font-Size="Large" />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageLocLarge") %>' />
        <br />
        <asp:Label ID="ManfacLabel" runat="server" Text='<%# Eval("Manfac") %>' />
<br />
        ShortDescrip:
        <asp:Label ID="ShortDescripLabel" runat="server" Text='<%# Eval("ShortDescrip") %>' />
        <br />
        Price:$
        <asp:Label ID="unitPriceLabel" runat="server" Text='<%# Eval("unitPrice") %>' />
        <br />
        Keywords:
        <asp:Label ID="KeywordsLabel" runat="server" Text='<%# Eval("Keywords") %>' />
        <br />
        <asp:DropDownList ID="Size" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:DropDownList ID="Quantity" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:HyperLink ID="AddToCart" runat="server">Add To Cart</asp:HyperLink>
        <br />
        <br />
    </ItemTemplate>
</asp:DataList>
</div>
</asp:Content>

