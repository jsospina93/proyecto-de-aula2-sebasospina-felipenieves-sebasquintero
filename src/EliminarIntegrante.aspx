<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarIntegrante.aspx.cs" Inherits="emprendimientor4rivisual.AgregarParticipante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 848px;
        }
        .auto-style3 {
            width: 303px;
        }
        .auto-style4 {
            margin-left: 39px;
        }
        .auto-style5 {
            margin-left: 109px;
        }
    </style>
</head>
<body style="margin-left: 339px">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblEliminarInt" runat="server" ForeColor="#FF9933"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Digite el código de su idea</td>
                    <td>
                        <asp:TextBox ID="TxtCodIdea" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Digite el id del integrante que desea eliminar</td>
                    <td>
                        <asp:TextBox ID="TxtIdInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="BtnMenu" runat="server" BackColor="#66FF99" CssClass="auto-style5" Text="Menú" OnClick="BtnMenu_Click" />
                    </td>
                    <td>
                        <asp:Button ID="BtnEliminarInt" runat="server" BackColor="#FF3300" CssClass="auto-style4" Text="Eliminar" OnClick="BtnEliminarInt_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
