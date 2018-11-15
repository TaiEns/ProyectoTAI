<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categorias_productos.aspx.cs" Inherits="TainEns.paginas.Cliente.Productos.categorias_productos" %>

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
    <title>Categorias de Productos</title>
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
	        <a class="nav-link text-white active" href="#">Productos</a>
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
        <div class="form-inline my-2 my-lg-0">
            <asp:TextBox ID="tbBuscarProducto" runat="server" class="form-control mr-sm-2" type="search" placeholder="Buscar Producto" aria-label="Search"></asp:TextBox>
            <button runat="server" id="btnRun" onserverclick="btnBuscar_Click" class="btn btn-outline-success my-2 my-sm-0"><i class="fas fa-search"></i></button>
            <div class="invalid-feedback">
                <asp:Label runat="server" ID="lblProductoNoEncontrado" Text=""></asp:Label>
            </div>
        </div>
        <asp:Label ID="msn" Text="" runat="server"></asp:Label>
        <div class="container">
            <div class="row">
                <h1 class="text-center">Productos</h1>
            </div>  
            <div class="row">
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded" runat="server">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/carnes.jpg" alt="Carnes"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Carnes</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnCarnes" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnCarnes_Click"/>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/bebidas.jpg" alt="Bebidas"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Bebidas</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnBebidas" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnBebidas_Click"/>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded" runat="server">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/higiene.jpg" alt="Higiene"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Higiene</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnHigiene" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnHigiene_Click"/>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/fruta.jpg" alt="Fruta"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Frutas</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnFrutas" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnFruta_Click"/>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded" runat="server">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/lacteos.jpg" alt="Lacteos"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Lacteos</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnLacteos" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnLacteos_Click"/>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/snacks.jpg" alt="Snacks"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Snacks</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnSnacks" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnSnacks_Click"/>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded" runat="server">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/pan.jpg" alt="Pan"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Panaderia</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnPanaderia" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnPanaderia_Click"/>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/Especias.jpg" alt="Especias"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Especias</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnEspecias" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnEspecias_Click"/>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="columna shadow-lg p-3 mb-5 bg-white rounded">
                    <div class="col-md-auto">
                        <div class="card" style="width: 18rem;">
                          <img class="card-img-top" src="../../../img/categorias/cereal.jpg" alt="Cereal"/>
                          <div class="card-body">
                            <h5 class="card-title text-center">Cereales</h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnCereales" runat="server" Text="Mirar" CssClass="btn btn-primary" style="margin-left: 38%;" OnClick="btnCereales_Click"/>
                          </div>
                        </div>
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
    <script type="text/javascript" src="../../../js/bootstrap.bundle.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>

</body>
</html>
