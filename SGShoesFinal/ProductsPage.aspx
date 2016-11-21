<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="SGShoesFinal.Masters.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DropDownList ID="CatDD" runat="server" AutoPostBack="True" DataSourceID="CatData" DataTextField="Type" DataValueField="Id">
    </asp:DropDownList>

    <asp:ObjectDataSource ID="ProductData" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.DBObject" DeleteMethod="DBObjectDelete" InsertMethod="DBObjectInsert" SelectMethod="DBObjectSelectAll" TypeName="SGShoesFinal.App_Code.DBUtils" UpdateMethod="DBObjectUpdate">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
    </asp:ObjectDataSource>
<asp:ObjectDataSource ID="CatData" runat="server" DataObjectTypeName="SGShoesFinal.App_Code.DBObject" DeleteMethod="DBObjectDelete" InsertMethod="DBObjectInsert" SelectMethod="DBObjectSelectAll" TypeName="SGShoesFinal.App_Code.DBUtils" UpdateMethod="DBObjectUpdate">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    </asp:ObjectDataSource>
<asp:DataList ID="DataList1" runat="server" DataSourceID="ProductData">
    <ItemTemplate>
        Id:
        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
        <br />
        Type:
        <asp:Label ID="TypeLabel" runat="server" Text='<%# Eval("Type") %>' />
        <br />
<br />
    </ItemTemplate>
</asp:DataList>

</asp:Content>
