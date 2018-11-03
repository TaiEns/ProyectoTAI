<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregar_producto.aspx.cs" Inherits="TainEns.paginas.Cliente.Negocios.agregar_producto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
    <link rel="stylesheet" type="text/css" href="../../../css/style.css"/>
    <link rel="stylesheet" type="text/css" href="../../../css/floating-labels.css"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
    <title>Agregar Producto</title>
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
	    </ul>

	    <form class="form-inline my-2 my-lg-0">
	      <div class="dropdown ">
			  <button class="btn btn-secondary dropdown-toggle azuloscuro Cantidad" type="button" id="dropdownMenu2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
			    <img src="../../../img/Cantidad.png" width="30" height="30"/>
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
        <div class="shadow-lg p-3 mb-5 bg-white rounded">
          <div class="text-center mb-4">
            <h1 class="h3 mb-3 font-weight-bold">Agregar Producto</h1>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <label for="Nombre">Nombre</label>
              <asp:TextBox ID="Nombre" runat="server" class="form-control" placeholder="Nombre" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="Nombre" placeholder="Nombre" required/>-->
            </div>
            <div class="col-md-4 mb-3">
              <label for="Precio">Precio</label>
                <asp:TextBox ID="Precio" runat="server" class="form-control" placeholder="Precio" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="Precio" placeholder="Precio" required/>-->
            </div>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <label for="Cantidad">Cantidad</label>
              <asp:TextBox ID="Cantidad" runat="server" class="form-control" placeholder="Cantidad" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="Cantidad" placeholder="Cantidad" required/>-->
            </div>
            <div class="col-md-4 mb-3">
              <label for="Presentacion">Presentacion</label>
              <asp:TextBox ID="Presentacion" runat="server" class="form-control" placeholder="Presentacion" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="Presentacion" placeholder="Presentacion" required/>-->
            </div>
          </div>
          <div class="form-group" style="max-width: 600px; margin: 10px auto;">
            <label for="Desctipcion">Descripción</label>
            <textarea class="form-control" id="Desctipcion" rows="3" ></textarea>
          </div>
          <div id="botones">
            <asp:Button ID="Agregar" runat="server" Text="Agregar" class="btn btn-lg btn-primary btn-block azuloscuro botones" data-toggle="modal"  data-target="#exampleModal" />
            <!--<button id="Agregar" class="btn btn-lg btn-primary btn-block azuloscuro botones" type="submit" data-toggle=""  data-target="#exampleModal">Agregar</button>-->
            <a id="Cancelar" class="btn btn-lg btn-primary btn-block azuloscuro botones cancelar" href="mis_negocios.aspx" style="margin-top: 0px;">Cancelar</a>
          </div>
        </div>
    </form>
    <!-- Modal -->
    <asp:Panel ID="pnModal" runat="server">
        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                <img src="../img/happyface.jpg"  width="100" height="100" style="margin: auto;"/>
                <div class="modal-header">
                    <h2 class="modal-title" id="exampleModalLabel" style="text-align: center;">Bienvenido</h2>
                </div>
                <div class="modal-body text-center">
                    Su registro se ha realizado con exito
                </div>
                </div>
            </div>
        </div>
    </asp:Panel>

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
    <script>
        $( document ).on("ready",main);
        function main(){
          var cont = 0;
          $("#Agregar").on("click", Validar);
        }

        function Incorrecto(tb){
          if($(tb).hasClass("is-valid")){
            $(tb).removeClass("is-valid");
            $(tb).addClass("is-invalid");
          }
          else{
            $(tb).addClass("is-invalid");
          }
        }

        function Correcto(tb){
          if($(tb).hasClass("is-invalid")){
            $(tb).addClass("is-valid");
            $(tb).removeClass("is-invalid");
          }
          else{
            $(tb).addClass("is-valid");
          }
        }

        function Validar(){
          var tbNombre = $("#Nombre").val();
          var tbPrecio = $("#Precio").val();
          var tbCantidad = $("#Cantidad").val();
          var tbPresentacion = $("#Presentacion").val();
          var tbContrasena = $("#Contrasena").val();
          var tbConfContrasena = $("#ConfContrasena").val();
          var cont = 0;

          if(tbNombre != ""){
            Correcto("#Nombre");
            cont++;
          }
          else{
            Incorrecto("#Nombre");
          }
          if(tbPrecio != ""){
            Correcto("#Precio");
            cont++;
          }
          else{
            Incorrecto("#Precio");
          }

          if(tbCantidad != ""){
            Correcto("#Cantidad");
            cont++;
          }
          else{
            Incorrecto("#Cantidad");
          }

          if(tbPresentacion != ""){
            Correcto("#Presentacion");
            cont++;
          }
          else{
            Incorrecto("#Presentacion");
          }

          if(tbContrasena != ""){
            Correcto("#Contrasena");
            cont++;
          }
          else{
            Incorrecto("#Contrasena");
          }

          if(tbConfContrasena != ""){
            Correcto("#ConfContrasena");
            cont++;
          }
          else{
            Incorrecto("#ConfContrasena");
            }

            if (tbContrasena != tbConfContrasena) {
                Incorrecto("#ConfContrasena");
                Incorrecto("#Contrasena");
            }
            else {
                Correcto("#ConfContrasena");
                Correcto("#Contrasena");
            }
          if(cont == 5){
            //$("#Agregar").attr("data-toggle", "modal");
            //redireccionar();
          }
        }

        function redireccionar() {
          setTimeout("location.href='../index.aspx'", 3000);
        }
  </script>
  <script type="text/javascript" src="../../../js/bootstrap.min.js"></script>
  <script type="text/javascript" src="../../../js/bootstrap.bundle.js"></script>
  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>

</body>
</html>
