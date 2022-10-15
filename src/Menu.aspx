<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="emprendimientor4rivisual.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 60%;
            height: 58px;
            margin-left: 266px;
        }
        .auto-style3 {
            height: 23px;
            width: 242px;
        }
        .auto-style4 {
            width: 242px;
        }
        .auto-style5 {
            height: 199px;
            width: 242px;
        }
        .auto-style6 {
            height: 199px;
        }
    </style>
</head>
<body style="height: 24px">
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Menú Emprendimientos 4RI<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblBienvenida" runat="server" Text="Bienvenid@ !"></asp:Label>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblIngresarOpcion" runat="server" Text="Elige una opcion:"></asp:Label>
                        <br />
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Ingresar idea de negocio</td>
                    <td class="auto-style1">
                        <asp:Button ID="BtnIngresarIdea" runat="server" Height="20px" OnClick="BtnIngresarIdea_Click" Text="Ingresar" Width="70px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Agregar integrante</td>
                    <td class="auto-style1">
                        <asp:Button ID="BtnAgregarIntegrante" runat="server" Height="20px" OnClick="BtnAgregarIntegrante_Click" Text="Agregar" Width="70px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Eliminar integrante</td>
                    <td class="auto-style1">
                        <asp:Button ID="BtnEliminirIntegrante" runat="server" Height="20px" OnClick="BtnEliminirIntegrante_Click" Text="Eliminar" Width="70px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Modificar valor inversión</td>
                    <td class="auto-style1">
                        <asp:Button ID="BtnModificarInversion" runat="server" Height="20px" OnClick="BtnModificarInversion_Click" Text="Modificar" Width="70px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Modificar total ingresos</td>
                    <td>
                        <asp:Button ID="BtnModificarIngresos" runat="server" Height="20px" OnClick="BtnModificarIngresos_Click" Text="Modificar" Width="70px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Mostrar estadísticas</td>
                    <td>
                        <asp:Button ID="Btnestadisticas" runat="server" Height="20px" OnClick="Btnestadisticas_Click" Text="Mostrar" Width="70px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="Txtestadisticas" runat="server" Height="236px" TextMode="MultiLine" Visible="False" Width="319px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
