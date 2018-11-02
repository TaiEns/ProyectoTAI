<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar_usuario.aspx.cs" Inherits="TainEns.paginas.registrar_usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
    <link rel="stylesheet" type="text/css" href="../css/style.css"/>
    <link rel="stylesheet" type="text/css" href="../css/floating-labels.css"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
    <title>Registrarse</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light azuloscuro">
        <a class="navbar-brand text-white" href="../index.html"><img src="../img/footer.png" width="30" height="30">TAI</a>
    </nav>
    <form id="form1" runat="server">
        <div class="shadow-lg p-3 mb-5 bg-white rounded">
          <div class="text-center mb-4">
            <h1 class="h3 mb-3 font-weight-bold">Registrarse</h1>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <label for="Nombres">Nombres</label>
              <input type="text" class="form-control" id="Nombres" placeholder="Nombres" required/>
            </div>
            <div class="col-md-4 mb-3">
              <label for="Apellidos">Apellidos</label>
              <input type="text" class="form-control" id="Apellidos" placeholder="Apellidos" required/>
            </div>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <label for="Usuario">Usuario</label>
              <input type="text" class="form-control" id="Usuario" placeholder="Usuario" required/>
            </div>
            <div class="col-md-4 mb-3">
              <label for="Correo">Correo</label>
              <input type="text" class="form-control" id="Correo" placeholder="Correo" required/>
            </div>
          </div>

          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <label for="Contrasena">Contraseña</label>
              <input type="password" class="form-control" id="Contrasena" placeholder="Contrasena" required/>
            </div>
            <div class="col-md-4 mb-3">
              <label for="ConfContrasena">Confirmar Contraseña</label>
              <input type="password" class="form-control" id="ConfContrasena" placeholder="Confirmar Contraseña" required/>
            </div>
         </div> 
          <div id="botones">
            <button id="Registrarse" class="btn btn-lg btn-primary btn-block azuloscuro botones" type="submit" data-toggle=""  data-target="#exampleModal">Registrarse</button>
            <a id="Cancelar" class="btn btn-lg btn-primary btn-block azuloscuro botones cancelar" href="../index.html" style="margin-top: 0px;">Cancelar</a>
          </div>
        </div>
    </form>

    <!-- Modal -->
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

    <footer class="footer azuloscuro">
        <div class="footer-content">
            <img src="../img/footer.png" width="50" height="50" id="Icono-footer"/><p>TAI</p>
            <div id="redes">
            <div id="enlaces-redes">
                <a href="#"><img src="../img/facebook-logo.png" width="30" height="30"/></a>
                <a href="#"><img src="../img/instagram-logo.png" width="30" height="30"/></a>
                <a href="#"><img src="../img/gmail-logo.png" width="30" height="30"/></a>
            </div>
            </div>
        </div>
    </footer>

     <script>
    $( document ).on("ready",main);
    function main(){
      var cont = 0;
      $("#Registrarse").on("click", Validar);
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
      var tbNombres = $("#Nombres").val();
      var tbApellidos = $("#Apellidos").val();
      var tbUsuario = $("#Usuario").val();
      var tbCorreo = $("#Correo").val();
      var tbContrasena = $("#Contrasena").val();
      var tbConfContrasena = $("#ConfContrasena").val();
      var cont = 0;

      if(tbNombres != ""){
        Correcto("#Nombres");
        cont++;
      }
      else{
        Incorrecto("#Nombres");
      }
      if(tbApellidos != ""){
        Correcto("#Apellidos");
        cont++;
      }
      else{
        Incorrecto("#Apellidos");
      }

      if(tbUsuario != ""){
        Correcto("#Usuario");
        cont++;
      }
      else{
        Incorrecto("#Usuario");
      }

      if(tbCorreo != ""){
        Correcto("#Correo");
        cont++;
      }
      else{
        Incorrecto("#Correo");
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
      if(cont == 5){
        $("#Registrarse").attr("data-toggle", "modal");
        //ar url = "../index.html"; 
        //$(location).attr('href',url).delay(10000);
        redireccionar();
      }
    }

    function redireccionar() {
      setTimeout("location.href='../index.html'", 3000);
    }
  </script>
  <script type="text/javascript">$('#primero').popover(options)</script>
  <script type="text/javascript" src="../js/bootstrap.min.js"></script>
  <script type="text/javascript" src="../js/bootstrap.bundle.js"></script>
  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
</body>
</html>
