<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Masivian.WebForm1" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>Masivian Test</title>
        <link href="https://fonts.googleapis.com/css2?family=David+Libre:wght@400;500;700&family=Peddana&display=swap" rel="stylesheet" />
        <link rel="stylesheet" href="css/normalize.css" />
        <link rel="stylesheet" href="css/StyleSheet1.css" />
        <style type="text/css">
            .auto-style16 {
                width: 5px;
            }
            
            .auto-style17 {
                width: 92px;
            }
            
            .auto-style18 {
                width: 87px;
                height: 66px;
            }
            .auto-style19 {
                width: 89%;
                height: 57px;
            }
            .auto-style20 {
                width: 321px;
                text-align: center;
            }
        </style>
    </head>

    <body style="height: 644px; width: 1495px;">
        <form id="form1" runat="server" class="auto-style12">
            <div>
                <h1 class="auto-style13">JUEGA LA RULETA</h1>
                <table class="auto-style19">
                    <tr>
                        <td class="auto-style20">
                            &nbsp;</td>
                        <td class="auto-style3">
                            <table id="table1" class="auto-style5">
                                <tr>
                                    <td class="auto-style11">&nbsp;</td>
                                    <td class="auto-style10">&nbsp;</td>
                                    <td class="auto-style9">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style11">
                                        <table style="width: 100%;">
                                            <tr>
                                                <td class="auto-style16">&nbsp;</td>
                                                <td class="auto-style17">&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style16">&nbsp;</td>
                                                <td class="auto-style17">&nbsp;</td>
                                                <td>
                                                    <img alt="flecha" id="Image2" class="auto-style18" src="Images/flecha.png" /></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style16">&nbsp;</td>
                                                <td class="auto-style17">&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="auto-style10">
                                        <asp:Image ID="Image1" runat="server" Height="490px" ImageUrl="~/Images/roulet.png" SkinID="Img1" />
                                    </td>
                                    <td class="auto-style9">
                                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Número:" Font-Names="Arial Black"></asp:Label>
                                        <asp:TextBox ID="TextBox1" runat="server" CausesValidation="True" MaxLength="36">0</asp:TextBox>
                                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Large" Text="Apuesta:" Font-Names="Arial Black"></asp:Label>
                                        <asp:TextBox ID="TextBox2" runat="server" CausesValidation="True" MaxLength="10000">0</asp:TextBox>
                                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Color:" Font-Names="Arial Black"></asp:Label>
                                        <br />
                                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Font-Size="Medium" Height="87px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" Width="114px" AutoPostBack="True" BorderColor="Black" EnableViewState="False" Font-Names="Arial Black" ForeColor="White" TextAlign="Left">
                                            <asp:ListItem Value="0">Negro</asp:ListItem>
                                            <asp:ListItem Value="1">Rojo</asp:ListItem>
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style11">&nbsp;</td>
                                    <td class="auto-style10">&nbsp;</td>
                                    <td class="auto-style9">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style3">
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style15">
                                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Font-Bold="True" Font-Size="Large" Text="Girar" />
                                    </td>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="XX-Large"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style15">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style15">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </body>

    </html>