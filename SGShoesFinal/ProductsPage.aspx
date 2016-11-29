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
<asp:DataList ID="DataList1" runat="server" DataSourceID="ProductData" RepeatColumns="3">
    <ItemTemplate>
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageLocSmall") %>' />
        <asp:HiddenField ID="ProdIDh" runat="server" Value='<%# Eval("Id", "{0}") %>' />
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
        <asp:DropDownList ID="SizeDD" runat="server" AutoPostBack="True" DataSourceID="SqlDetailDataSize" DataTextField="Size" DataValueField="Size">
        </asp:DropDownList>
        <asp:DropDownList ID="QuantDD" runat="server" AutoPostBack="True" DataSourceID="SqlDetailDataQuant" DataTextField="Quantity" DataValueField="Quantity">
        </asp:DropDownList>
<br />
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
</asp:Content>

