<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" MasterPageFile="~/Masters/ProductMaster.Master" Inherits="SGShoesFinal.ProductsPage" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class ="Main">
            <div class ="top-right shopbag">
                <asp:ImageButton ID="ShopingCartButton" runat="server" ImageUrl="~/Images/shopping-purse.png"  PostBackUrl="~/ShoppingCart.aspx" />
            </div>
        <h2 class="logo">S&G SHOES<img src="../Images/logo.jpg" alt="S&G Shoes" /></h2>
        <div class="navbar">
            <a class="menul" href="INDEX.aspx">HOME</a>
            <span class="navbar_spacer">//</span>
            <a class="menul" href="ProductsPage.aspx"> PRODUCTS</a>
            <span class="navbar_spacer">//</span>
            <a class="menul" href="LoginPage.aspx">LOGIN</a>
            <span class="navbar_spacer">//</span>
            <a class="menul" href="Page3.aspx">MY ACCOUNT</a>                
        </div>
            </div> 

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
<asp:DataList ID="DataList1" runat="server" DataSourceID="ProductData" RepeatColumns="3" CssClass="product_list" Font-Names="Tahoma,Arial,sans-serif" HorizontalAlign="Center">
    <ItemTemplate>
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageLocSmall") %>' BorderStyle="None" BorderWidth="1px" />
        <input id="Hidden1" type="hidden" />
        <input id="Hidden2" type="hidden" />
        <br />
        <div>
        </div>
        <asp:HiddenField ID="ProdIDh" runat="server" Value='<%# Eval("Id", "{0}") %>' />
        <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProdName") %>' />
        <br />
        <asp:Label ID="ManfacLabel" runat="server" Text='<%# Eval("Manfac") %>' Font-Size="Smaller" />
        <br />
        <asp:Label ID="ShortDescripLabel" runat="server" Text='<%# Eval("ShortDescrip") %>' />
        <br />
        <asp:Label ID="unitPriceLabel" runat="server" Text='<%# string.Format("{0:C}", Eval("unitPrice")) %>' Font-Bold="True" />
        <div>
        </div>
        <asp:DropDownList ID="SizeDD" runat="server" AutoPostBack="True" DataSourceID="SqlDetailDataSize" DataTextField="Size" DataValueField="Size">
        </asp:DropDownList>
        <asp:DropDownList ID="QuantDD" runat="server" AutoPostBack="True" DataSourceID="SqlDetailDataQuant" DataTextField="Quantity" DataValueField="Quantity" OnDataBound="QuantDD_DataBound">
        </asp:DropDownList>
        <div>
        </div>
<br />
        <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Add To Cart" />
        <asp:SqlDataSource ID="SqlDetailDataSize" runat="server" ConnectionString="<%$ ConnectionStrings:fall16_g2ConnectionString %>" SelectCommand="SELECT [Size] FROM [Product_Detail] WHERE ([Product_Id] = @Product_Id)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ProdIDh" Name="Product_Id" PropertyName="Value" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDetailDataQuant" runat="server" ConnectionString="<%$ ConnectionStrings:fall16_g2ConnectionString %>" SelectCommand="SELECT [Quantity] FROM [Product_Detail] WHERE ([Size] = @Size)">
            <SelectParameters>
                <asp:ControlParameter ControlID="SizeDD" Name="Size" PropertyName="SelectedValue" Type="Double" />
            </SelectParameters>
        </asp:SqlDataSource>
    </ItemTemplate>
</asp:DataList>
</div>
        </div>

</asp:Content>
