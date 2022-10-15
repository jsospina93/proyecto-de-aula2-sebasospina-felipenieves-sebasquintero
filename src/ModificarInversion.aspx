<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarInversion.aspx.cs" Inherits="emprendimientor4rivisual.ModificarIngresos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 46%;
            margin-left: 259px;
        }
        .auto-style2 {
            width: 240px;
        }
        .auto-style3 {
            margin-left: 103px;
        }
        .auto-style4 {
            margin-left: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblModificarInv" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Digite el código de su idea</td>
                    <td>
                        <asp:TextBox ID="TxtCodIdea" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Digite el nuevo valor de la inversión</td>
                    <td>
                        <asp:TextBox ID="TxtValInv" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="BtnMenu" runat="server" BackColor="#66FFCC" CssClass="auto-style3" Height="22px" OnClick="BtnMenu_Click" Text="Menú" Width="68px" />
                    </td>
                    <td>
                        <asp:Button ID="BtnGuardarInv" runat="server" BackColor="#66FF99" CssClass="auto-style4" Height="22px" OnClick="BtnGuardarInv_Click" Text="Guardar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
