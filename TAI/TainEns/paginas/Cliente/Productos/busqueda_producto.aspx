<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="busqueda_producto.aspx.cs" Inherits="TainEns.paginas.Cliente.Productos.busqueda_producto" %>

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
    <title>Productos</title>
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
	        <a class="nav-link text-white active" href="#">Lista</a>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link text-white active" href="categorias_productos.aspx">Productos</a>
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
            
            <asp:GridView ID="grvProductos" runat="server" AutoGenerateColumns="False" DataKeyNames="IdProducto" OnSelectedIndexChanged="grvProductos_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="NombreProducto" HeaderText="Nombre" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                    <asp:CommandField ButtonType="Button" HeaderText="Mostrar" SelectText="Mostrar" ShowSelectButton="True">
                    <ControlStyle CssClass="btn btn-primary" />
                    </asp:CommandField>
                </Columns>
            </asp:GridView>
        </div>

        <!-- Modal -->
        <asp:Panel ID="pProducto" runat="server"  class="card form-signin" style="width: 25rem;">
            <img class="card-img-top" src="../../../img/calis_producto.jpg" alt="Card image cap"/>
            <div class="card-body">
                <h5 class="card-title"><asp:Label runat="server" ID="lblCardTitle" Text=""></asp:Label></h5>
                <div class="text-center">
                    <asp:Label runat="server" ID="lblMarca" Text=""></asp:Label><br />
                    <asp:Label runat="server" ID="lblCantidad" Text=""></asp:Label>
                    <asp:Label runat="server" ID="lblMedida" Text=""></asp:Label>
                </div>
                <asp:DropDownList ID="ddlListasProductos" runat="server" CssClass="form-control" >
                </asp:DropDownList>
                <asp:Button ID="btnAgregaraLista" runat="server" Text="Agregar" class="btn btn-primary" OnClick="btnAgregaraLista_Click" />
                <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" class="btn btn-primary cancelar" OnClick="btnCerrar_Click" />
            </div>
        </asp:Panel>
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
    <!--<script type="text/javascript" src="../../../js/bootstrap.bundle.js"></script>-->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>

</body>
</html>
