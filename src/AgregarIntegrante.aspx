<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarIntegrante.aspx.cs" Inherits="emprendimientor4rivisual.AgregarIntegrante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 382px;
        }
        .auto-style2 {
            width: 64%;
            margin-left: 180px;
        }
        .auto-style3 {
            margin-left: 208px;
        }
        .auto-style4 {
            margin-left: 96px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblAgregarInt" runat="server" ForeColor="#FF9933"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Digite el codigo de su idea:</td>
                    <td>
                        <asp:TextBox ID="TxtCodIdea" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ingrese el id del integrante a agregar:</td>
                    <td>
                        <asp:TextBox ID="TxtIdInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ingrese el nombre del integrante a agregar:</td>
                    <td>
                        <asp:TextBox ID="TxtNomInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ingrese el apellido del integrante a agregar:</td>
                    <td>
                        <asp:TextBox ID="TxtApeint" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ingrese el rol del integrante a agregar:</td>
                    <td>
                        <asp:TextBox ID="TxtRolInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ingrese el correo del integrante a agregar:</td>
                    <td>
                        <asp:TextBox ID="TxtCorreoInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="BtnMenu" runat="server" BackColor="#66FF99" CssClass="auto-style4" Text="Menu" Width="96px" OnClick="Button1_Click" />
                        <asp:Button ID="BtnAgregarInt" runat="server" BackColor="#66FFFF" CssClass="auto-style3" Text="Agregar" Width="101px" OnClick="BtnAgregarInt_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
