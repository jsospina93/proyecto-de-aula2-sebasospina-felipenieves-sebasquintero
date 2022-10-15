<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarIngresos.aspx.cs" Inherits="emprendimientor4rivisual.ModificarInversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 54%;
            margin-left: 265px;
        }
        .auto-style2 {
            width: 218px;
        }
        .auto-style3 {
            margin-left: 77px;
        }
        .auto-style4 {
            margin-left: 42px;
        }
    </style>
</head>
<body style="width: 773px; height: 243px;">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblModIng" runat="server" ForeColor="#FF9933"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Digite el código de su idea:</td>
                    <td>
                        <asp:TextBox ID="TxtCodIdea" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Digite el nuevo total de los ingresos:</td>
                    <td>
                        <asp:TextBox ID="TxtTotIng" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="BtnMenu" runat="server" BackColor="#66FFCC" CssClass="auto-style3" OnClick="BtnMenu_Click" Text="Menú" Width="67px" />
                    </td>
                    <td>
                        <asp:Button ID="BtnGuardarIng" runat="server" BackColor="#66FF99" CssClass="auto-style4" OnClick="BtnGuardarIng_Click" Text="Guardar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
