﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tablas.aspx.cs" Inherits="TainEns.tablas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuarios <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IdUsuarios" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="IdUsuarios" HeaderText="IdUsuarios" InsertVisible="False" ReadOnly="True" SortExpression="IdUsuarios" />
                    <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario" />
                    <asp:BoundField DataField="EmailUsuario" HeaderText="EmailUsuario" SortExpression="EmailUsuario" />
                    <asp:BoundField DataField="PasswordUsuario" HeaderText="PasswordUsuario" SortExpression="PasswordUsuario" />
                    <asp:BoundField DataField="EstatusUsuario" HeaderText="EstatusUsuario" SortExpression="EstatusUsuario" />
                    <asp:BoundField DataField="NombreNegocio" HeaderText="NombreNegocio" SortExpression="NombreNegocio" />
                    <asp:BoundField DataField="DireccionNegocio" HeaderText="DireccionNegocio" SortExpression="DireccionNegocio" />
                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
                </Columns>
            </asp:GridView>
            Roles <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="IdRol" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="IdRol" HeaderText="IdRol" InsertVisible="False" ReadOnly="True" SortExpression="IdRol" />
                    <asp:BoundField DataField="NombreRol" HeaderText="NombreRol" SortExpression="NombreRol" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                </Columns>
            </asp:GridView>
            Usuario - Rol <br />
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
                <Columns>
                    <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" SortExpression="IdUsuario" />
                    <asp:BoundField DataField="IdRol" HeaderText="IdRol" SortExpression="IdRol" />
                </Columns>
            </asp:GridView>
            Negocios <br />
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="IdNegocios" DataSourceID="SqlDataSource4">
                <Columns>
                    <asp:BoundField DataField="IdNegocios" HeaderText="IdNegocios" InsertVisible="False" ReadOnly="True" SortExpression="IdNegocios" />
                    <asp:BoundField DataField="DiasLaborales" HeaderText="DiasLaborales" SortExpression="DiasLaborales" />
                    <asp:BoundField DataField="TipoNegocio" HeaderText="TipoNegocio" SortExpression="TipoNegocio" />
                    <asp:BoundField DataField="TelefonoNegocio" HeaderText="TelefonoNegocio" SortExpression="TelefonoNegocio" />
                    <asp:BoundField DataField="NombreNegocio" HeaderText="NombreNegocio" SortExpression="NombreNegocio" />
                    <asp:BoundField DataField="DireccionNegocio" HeaderText="DireccionNegocio" SortExpression="DireccionNegocio" />
                    <asp:BoundField DataField="EstadoNegocio" HeaderText="EstadoNegocio" SortExpression="EstadoNegocio" />
                </Columns>
            </asp:GridView>
            Usuario - Negocio <br />
            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5">
                <Columns>
                    <asp:BoundField DataField="IdNegocios" HeaderText="IdNegocios" SortExpression="IdNegocios" />
                    <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" SortExpression="IdUsuario" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT * FROM [tbUsuarioNegocios]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT * FROM [tbNegocios]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT * FROM [tbUsuarioRol]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT * FROM [tbRoles]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT * FROM [tbUsuarios]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>