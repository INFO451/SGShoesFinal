<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SGShoesFinal.Masters.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<center style="height: 215px">  <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" DestinationPageUrl="~/PagesAdmin/AdminProduct.aspx" DisplayRememberMe="false" BackColor="White" Font-Names="Tahoma" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Height="182px" Width="391px">
      <LayoutTemplate>
          <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
              <tr>
                  <td>
                      <table cellpadding="0">
                          <tr>
                              <td align="center" colspan="2" style="height: 19px">Log In</td>
                          </tr>
                          <tr>
                              <td align="left">
                                  <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" CssClass="loginText" Font-Bold="False">User Name:</asp:Label>
                              </td>
                              <td colspan="0" style="width: 5px">&nbsp;</td>
                          </tr>
                          <tr>
                              <td align="center">
                                  <asp:TextBox ID="UserName" runat="server" CssClass="loginBox"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                              <td align="left" colspan="2" style="color:black;">
                                  <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" CssClass="loginText" Font-Bold="False" ForeColor="Black">Password:</asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td align="center" colspan="2">
                                  <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="loginBox"></asp:TextBox>
                                  <br />
                                  <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" />
                              </td>
                          </tr>
                      </table>
                  </td>
              </tr>
          </table>
      </LayoutTemplate>
  </asp:Login>  </center>

    
</asp:Content>
