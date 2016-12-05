<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SGShoesFinal.Masters.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<center style="height: 215px">  <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" DestinationPageUrl="~/PagesAdmin/AdminProduct.aspx" DisplayRememberMe="false" BackColor="White" Font-Names="Tahoma" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Height="182px" Width="391px">
      <LayoutTemplate>
          <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
              <tr>
                  <td>
                      <table cellpadding="0">
                          <tr>
                              
                              <td padding="300" align="center" colspan="2" style="height: 19px">&nbsp;</td>
                            
                          </tr>
                          <tr>
                              <td align="left">
                                  <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" CssClass="loginText" Font-Bold="False">User Name:</asp:Label>
                              </td>
                              <td colspan="0" style="width: 5px">&nbsp;</td>
                          </tr>
                          <tr>
                              <td align="center" style="height: 20px">
                                  <asp:TextBox ID="UserName" runat="server" CssClass="loginBox" Width ="300px"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                              <td align="left" colspan="2" style="color:black; height: 20px;">
                                  <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" CssClass="loginText" Font-Bold="False" ForeColor="Black">Password:</asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td align="center" colspan="2">
                                  <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="300px" CssClass="loginBox"></asp:TextBox>
                                  <br />
                                  <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" Font-Bold="True" ForeColor="Black" BackColor="#669999" BorderStyle="Ridge" />
                              </td>
                          </tr>
                      </table>
                  </td>
              </tr>
          </table>
      </LayoutTemplate>
  </asp:Login>  </center>

    
</asp:Content>
