<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarIdea.aspx.cs" Inherits="emprendimientor4rivisual.AgregarIdea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 48%;
            margin-left: 226px;
        }
        .auto-style2 {
            width: 256px;
        }
        .auto-style3 {
            margin-left: 4px;
        }
        .auto-style4 {
            margin-left: 139px;
        }
        .auto-style5 {
            margin-left: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Ingrese nombre de la idea:</td>
                    <td>
                        <asp:TextBox ID="TxtNombreIdea" runat="server" Width="208px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ingrese el impacto social o económico que genera:</td>
                    <td>
                        <asp:TextBox ID="Txtimpacto" runat="server" Height="28px" TextMode="MultiLine" Width="210px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Departamentos beneficiados:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Ingrese el código del departamento:</td>
                    <td>
                        <asp:TextBox ID="TxtCodDep" runat="server" Width="212px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ingrese el nombre del departamento:</td>
                    <td>
                        <asp:TextBox ID="TxtNomDep" runat="server"></asp:TextBox>
                        <asp:Button ID="BtnAgregarDep" runat="server" BackColor="#66CCFF" Height="20px" OnClick="BtnAgregarDep_Click" Text="Agregar" Width="86px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblAgregarDep" runat="server" ForeColor="#FF9933"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Integrantes del equipo:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Ingrese el id del integrante:</td>
                    <td>
                        <asp:TextBox ID="TxtIdInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ingrese el nombre del integrante:</td>
                    <td>
                        <asp:TextBox ID="TxtNomInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ingrese el apellido del integrante</td>
                    <td>
                        <asp:TextBox ID="TxtApeInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ingrese el rol del integrante</td>
                    <td>
                        <asp:TextBox ID="TxtRolInt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ingrese el correo del integrante:</td>
                    <td>
                        <asp:TextBox ID="TxtCorreoInt" runat="server"></asp:TextBox>
                        <asp:Button ID="BtnAgregarInt" runat="server" BackColor="#66CCFF" CssClass="auto-style3" Height="20px" OnClick="BtnAgregarInt_Click" Text="Agregar" Width="86px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblAgregarInt" runat="server" ForeColor="#FF9933"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ingrese el valor de la inversión</td>
                    <td>
                        <asp:TextBox ID="TxtValInv" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ingrese el total de ingresos a generar en los primeros tres años</td>
                    <td>
                        <asp:TextBox ID="TxtTotalIngresos" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Herramientas 4RI utilizadas (mínimo 1)</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Ingrese la herramienta 4RI</td>
                    <td>
                        <asp:TextBox ID="TxtHerramienta" runat="server"></asp:TextBox>
                        <asp:Button ID="BtnHerramienta" runat="server" BackColor="#66CCFF" Height="20px" OnClick="BtnHerramienta_Click" Text="Agregar" Width="86px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblHerramienta" runat="server" ForeColor="#FF9933"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="BtnMenu" runat="server" BackColor="#66FF99" CssClass="auto-style5" Height="23px" OnClick="BtnMenu_Click" Text="Menú" Width="106px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnGuardarIdea" runat="server" BackColor="#66FFFF" CssClass="auto-style4" Height="23px" OnClick="Button4_Click" Text="Guardar" Width="106px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblAgregarIdea" runat="server" ForeColor="#FF9933"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
