<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultar_negocio.aspx.cs" Inherits="TainEns.paginas.Cliente.Negocios.consultar_negocio" %>

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
    <title>Buscar Negocio</title>
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
	        <a class="nav-link text-white active" href="#">Mis Negocios</a>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link text-white active" href="#">Lista</a>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link text-white active" href="../Productos/categorias_productos.aspx">Productos</a>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link text-white active" href="buscar_negocio.aspx">Negocios</a>
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

    <asp:Panel ID="Panel1" runat="server">
        <div class="container">
            <div class="row">
                <h1><asp:Label ID="lbnegocio" runat="server" Text=""></asp:Label></h1>   
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-md-4 col-xs-12">
                    <div class="card" style="width: 18rem;">
                      <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="lbnombreneg" runat="server" Text="Label"></asp:Label>
                        </h5>
                        <p class="card-text">
                            <asp:Label ID="lbubicacionneg" runat="server" Text="Label"></asp:Label>
                        </p>
                        <p class="card-text">
                            <asp:Label ID="lbtiponeg" runat="server" Text="Label"></asp:Label>
                        </p>
                        <p class="card-text">
                            <asp:Label ID="lbnumneg" runat="server" Text="Label"></asp:Label>
                        </p>
                         <p class="card-text">Horario</p>
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
                <div class="col-md-8 col-xs-12">
                    <h2>Lista de Productos</h2>
                    <form id="form1" runat="server">
                        <asp:GridView ID="gridNombreP" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="NombreProducto" HeaderText="Producto" />
                                <asp:BoundField DataField="MedidaProducto" HeaderText="Precio" />
                            </Columns>
                        </asp:GridView>
                    </form>
                </div>
            </div>
        </div>
    </asp:Panel>
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
    <script type="text/javascript" src="../../../js/bootstrap.bundle.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>

</body>
</html>
