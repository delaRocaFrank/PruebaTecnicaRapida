<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colaboradores.aspx.cs" Inherits="NOM.WA.DATOSEMPLEADO.FE.Colaboradores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <!-- Bootstrap -->
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

</head>

<body style="height: 389px">
    <form id="form1" runat="server">
        <div style="height: 295px">
            <h1 class="h2">Colaboradores</h1>
            <asp:GridView ID="GridView1" runat="server" Height="286px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="887px" OnRowCommand="GridView1_RowCommand" CssClass="table table-striped table-bordered table-hover table-condensed" OnInit="GridView1_Init">
            </asp:GridView>
            <asp:Button ID="Update" runat="server" OnClick="Button1_Click" Text="Cargar Colaboradores" Width="243px" class="btn btn-dark" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
