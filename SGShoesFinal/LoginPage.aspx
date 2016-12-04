<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SGShoesFinal.Masters.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" DestinationPageUrl="~/PagesAdmin/AdminProduct.aspx" DisplayRememberMe="false">
    </asp:Login>

    
</asp:Content>
