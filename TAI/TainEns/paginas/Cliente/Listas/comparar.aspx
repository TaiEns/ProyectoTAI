<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comparar.aspx.cs" Inherits="TainEns.paginas.Cliente.Listas.comparar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
    <link rel="stylesheet" type="text/css" href="../../../css/style.css"/>
    <link rel="stylesheet" type="text/css" href="../../../css/floating-labels.css"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
    <title>Comparar</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light azuloscuro">
	  <a class="navbar-brand text-white" href="#"><img src="../../../img/footer.png" width="30" height="30"/>TAI</a>
	  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
	    <span class="navbar-toggler-icon"></span>
	  </button>

	  <div class="collapse navbar-collapse" id="navbarSupportedContent">
	    <ul class="navbar-nav mr-auto">
	      <li class="nav-item active">
	        <a class="nav-link text-white" href="../cliente.aspx">Inicio <span class="sr-only">(current)</span></a>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link text-white active" href="../Negocios/mis_negocios.aspx">Mis Negocios</a>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link text-white active" href="listas.aspx">Lista</a>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link text-white active" href="../Productos/categorias_productos.aspx">Productos</a>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link text-white active" href="../Negocios/buscar_negocio.aspx">Negocios</a>
	      </li>
	    </ul>

	    <form class="form-inline my-2 my-lg-0">
	      <div class="dropdown ">
			  <button class="btn btn-secondary dropdown-toggle azuloscuro Cantidad" type="button" id="dropdownMenu2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
			    <img src="../../../img/usuario.png" width="30" height="30"/>
			  </button>
			  <div class="dropdown-menu dropdown-menu-right" aria-labelledby="dropdownMenu2">
			    <button class="dropdown-item" type="button">Configuración <i class="fas fa-edit"></i></button>
                <a class="dropdown-item" href="../../../index.aspx">Cerrar Sesión <i class="fas fa-sign-out-alt"></i></a>
			  </div>
			</div>
	    </form>
	  </div>
	</nav>

    <form id="form1" runat="server">
        <div class="container">
            <h1 class="align-content-center"><asp:Label runat="server" ID="lblTitulo" Text="Elige un Negocio"></asp:Label></h1>
            <div class="row">
                <div class="col-sm">
                    <h5>Elige un negocio</h5>
                    <asp:DropDownList ID="ddlNegocio" runat="server" class="form-control" DataSourceID="SqlDataSource1" DataTextField="NombreNegocio" DataValueField="NombreNegocio" OnSelectedIndexChanged="ddlNegocio_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT [NombreNegocio] FROM [tbNegocios]"></asp:SqlDataSource>
                    <asp:Button ID="btnComparar" runat="server" Text="Comparar" class="btn btn-outline-primary" OnClick="btnComparar_Click"/>
                </div>
                <div class="col-sm">
                    <h5><asp:Label runat="server" ID="lblNombreLista" Text=""></asp:Label></h5>
                    <asp:GridView ID="grvProductosEncontrados" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Producto" />
                            <asp:BoundField DataField="Precio" HeaderText="Precio" />
                        </Columns>
                    </asp:GridView>
                    <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-sm">
                    <div class="shadow p-3 mb-5 bg-white rounded">
                        <h5>Productos no encontrados</h5>
                        <asp:GridView ID="grvProductosNoEnocntrados" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Nombre" HeaderText="Producto" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    <div class="shadow p-3 mb-5 bg-white rounded" runat="server" id="pNegocioInfo">
                        <asp:Label ID="lblNombreNegocio" runat="server" Text=""></asp:Label>
                        <asp:Label ID="lblUbicacion" runat="server" Text=""></asp:Label>
                        <asp:Label ID="lblTipo" runat="server" Text=""></asp:Label>
                        <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
                        Lunes:<asp:Label ID="lblL" runat="server" Text=""></asp:Label>
                        Martes:<asp:Label ID="lblM" runat="server" Text=""></asp:Label>
                        Miercoles:<asp:Label ID="lblMi" runat="server" Text=""></asp:Label>
                        Jueves:<asp:Label ID="lblJ" runat="server" Text=""></asp:Label>
                        Viernes:<asp:Label ID="lblV" runat="server" Text=""></asp:Label>
                        Sabado:<asp:Label ID="lblS" runat="server" Text=""></asp:Label>
                        Domingo:<asp:Label ID="lblD" runat="server" Text=""></asp:Label>
                    </div>
                    
                </div>
            </div>
        </div>
    </form>
    <!--
    <footer class="footer azuloscuro">
    	<div class="footer-content">
      		<img src="../../../img/footer.png" width="50" height="50" id="Icono-footer"/><p>TAI<div id="redes">
        		<div id="enlaces-redes">
          			<a href="#"><img src="../../../img/facebook-logo.png" width="30" height="30"/></a>
          			<a href="#"><img src="../../../img/instagram-logo.png" width="30" height="30"/></a>
          			<a href="#"><img src="../../../img/gmail-logo.png" width="30" height="30"/></a>
        		</div>
      		</div>
    	</div>
    </footer>
        -->
    <script type="text/javascript" src="../../../js/bootstrap.min.js"></script>
</body>
</html>
