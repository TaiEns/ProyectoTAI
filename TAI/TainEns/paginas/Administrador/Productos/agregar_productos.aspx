<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregar_productos.aspx.cs" Inherits="TainEns.paginas.Administrador.Productos.agregar_productos" %>

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
	        <a class="nav-link text-white" href="../administrador.aspx">Inicio <span class="sr-only">(current)</span></a>
	      </li>
	      <li class="nav-item dropdown active">
	        <a class="nav-link dropdown-toggle text-white" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
	          Solicitudes
	        </a>
	        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
	          <a class="dropdown-item" href="../Solicitudes/solicitud_productos.aspx">Productos</a>
            </div>
	      </li>
	      <li class="nav-item">
	        <a class="nav-link active text-white" href="#">Productos</a>
	      </li>
	    </ul>
       </div>
    </nav>

    <form id="form1" runat="server">
        <div class="shadow-lg p-3 mb-5 bg-white rounded">
          <div class="text-center mb-4">
            <h1 class="h3 mb-3 font-weight-bold">Agregar Producto Inicial</h1>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <label for="Categoria">Categoria</label>
              <asp:DropDownList ID="ddlCategoria" runat="server" class="form-control" >
                <asp:ListItem Value="Categoria">Categoria</asp:ListItem>
                <asp:ListItem Value="Cereales">Cereales</asp:ListItem>
                <asp:ListItem Value="Bebidas">Bebidas</asp:ListItem>
                <asp:ListItem Value="Higiene">Higiene</asp:ListItem>
                <asp:ListItem Value="Fruta">Fruta</asp:ListItem>
                <asp:ListItem Value="Lacteos">Lacteos</asp:ListItem>
                <asp:ListItem Value="Snacks">Snacks</asp:ListItem>
                <asp:ListItem Value="Carnes">Carnes</asp:ListItem>
                <asp:ListItem Value="Panaderia">Panaderia</asp:ListItem>
                <asp:ListItem Value="Especias">Especias</asp:ListItem>
            </asp:DropDownList>
            </div>
            <div class="col-md-4 mb-3">
              <label for="Nombre">Nombre</label>
              <asp:TextBox ID="Nombre" runat="server" class="form-control" placeholder="Nombre" required></asp:TextBox>
            </div>
          </div>
          <div class="form-row form-input">
              <div class="col-md-4 mb-3">
                <label for="Marca">Marca</label>
                <asp:TextBox ID="Marca" runat="server" class="form-control" placeholder="Marca" required></asp:TextBox>
              </div>
              <div class="col-md-4 mb-3">
              <label for="Presentacion">Presentacion</label>
              <asp:FileUpload ID="Presentacion" runat="server" required/>
            </div>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
                <label for="Cantidad">Cantidad</label>
                <asp:TextBox ID="Cantidad" runat="server" class="form-control" placeholder="Cantidad" required></asp:TextBox>
                
            </div>
              <div class="col-md-4 md-3">
                  <label for="ddlMedida">Medida</label>
                    <asp:DropDownList ID="ddlMedida" runat="server" class="form-control" >
                        <asp:ListItem Value="Medida">Medida</asp:ListItem>
                        <asp:ListItem Value="Piezas">Piezas</asp:ListItem>
                        <asp:ListItem Value="Gramos">Gramos</asp:ListItem>
                        <asp:ListItem Value="Kilos">Kilos</asp:ListItem>
                        <asp:ListItem Value="Mililitros">Mililitros</asp:ListItem>
                        <asp:ListItem Value="Litro">Litro</asp:ListItem>
                        <asp:ListItem Value="Litros">Litros</asp:ListItem>
                        <asp:ListItem Value="Galon">Galón</asp:ListItem>
                        <asp:ListItem Value="Galones">Galones</asp:ListItem>
                    </asp:DropDownList>
              </div>
          </div>
          <div class="form-group" style="max-width: 600px; margin: 10px auto;">
            <label for="Descripcion">Descripción</label>
            <textarea class="form-control " id="Descripcion" rows="3" runat="server"></textarea>
          </div>
          <div id="form-row form-input botones">
            <asp:Button ID="Agregar" runat="server" Text="Agregar" class="btn btn-lg btn-primary btn-block azuloscuro botones" data-toggle=""  data-target="#exampleModal" OnClick="Agregar_Click" />
            <a id="Cancelar" class="btn btn-lg btn-primary btn-block azuloscuro botones cancelar" href="productos.aspx" style="margin-top: 0px;">Cancelar</a>
          </div>
        </div>
        
        <!-- Modal -->
        <asp:Panel ID="pnModal" runat="server">
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                    <div class="modal-header">
                        <h2 class="modal-title" id="exampleModalLabel" style="text-align: center;">Agregado</h2>
                    </div>
                    <div class="modal-body text-center">
                        El producto se agrego correctamente
                    </div>
                    </div>
                </div>
            </div>
        </asp:Panel>
    </form>

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
        var ddlCategoria = $("#ddlCategoria").val();
        var tbCantidad = $("#Cantidad").val();
        var tbPresentacion = $("#Presentacion").val();
        var ddlMedida = $("#ddlMedida").val();
        var Marca = $("#Marca").val();
        var cont = 0;

        if(tbNombre != ""){
        Correcto("#Nombre");
        cont++;
        }
        else{
        Incorrecto("#Nombre");
        }
        if(ddlCategoria != "Categoria"){
        Correcto("#ddlCategoria");
        cont++;
        }
        else{
        Incorrecto("#ddlCategoria");
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
        if (ddlMedida != "Medida") {
        Correcto("#ddlMedida");
        cont++;
        }
        else{
        Incorrecto("#ddlMedida");
        }
        if (Marca != "") {
        Correcto("#Marca");
        cont++;
        }
        else{
        Incorrecto("#Marca");
        }
          
        if(cont == 6){
        $("#Agregar").attr("data-toggle", "modal");
        }
    }
  </script>
  <script type="text/javascript" src="../../../js/bootstrap.min.js"></script>
  <script type="text/javascript" src="../../../js/bootstrap.bundle.js"></script>
  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>

</body>
</html>
