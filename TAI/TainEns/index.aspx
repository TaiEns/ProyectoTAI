<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TainEns.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
    <link rel="stylesheet" type="text/css" href="CSS/style.css"/>
    <link rel="stylesheet" type="text/css" href="css/floating-labels.css"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
    <title>Iniciar Sesión</title>
</head>
<body>
    <nav class="navbar navbar-light">
        <a class="navbar-brand"></a>
        <form class="form-inline" action="#">
            <button type="button" class="btn btn-outline-primary">Registrarse</button>
        </form>
    </nav>
    <form id="frmIniciarSesion" class="form-signin" runat="server">
        <div class="shadow-lg p-3 mb-5 bg-white rounded">
            <div class="text-center mb-4">
                <img class="mb-4" src="img/LOGO-1.png" alt="TAI" width="80" height="120"/>
                <h1 class="h3 mb-3 font-weight-normal">Iniciar Sesión</h1>
            </div>
            <div class="form-row">
                <label for="Usuario">Usuario</label>
                <input type="text" class="form-control" id="Usuario" placeholder="Usuario" required/>
            </div>
            <div class="form-row">
                <label for="Contrasena">Contraseña</label>
                <input type="password" class="form-control" id="Contrasena" placeholder="Contraseña" required/>
                <div class="invalid-feedback">
                    ¿Y la contraseña?
                </div>
            </div>
            <div class="checkbox mb-3">
                <label>
                <a href="#">Olvide mi Contraseña</a>
                </label>
            </div>
        
            <button id="IniciarSesion" class="btn btn-lg btn-primary btn-block azuloscuro" type="submit">Iniciar Sesión</button>

            <div class="alert alert-warning alert-dismissible fade show bg-danger" role="alert" style="margin-bottom: 0; height: 40px;">
                <p style="color: #fff; font-family: Roboto; margin-bottom: 0; display: inline; margin: auto;">Usuario o contraseña incorrectos</p>
                <button type="button" class="close" data-dismiss="alert" aria-label="Close" style="color: #fff;">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
        </div>
    </form>
    <footer class="footer azuloscuro">
        <div class="footer-content">
          <img src="img/footer.png" width="50" height="50" id="Icono-footer"/><p>TAI</p>
          <div id="redes">
            <div id="enlaces-redes">
              <a href="#"><img src="img/facebook-logo.png" width="30" height="30"/></a>
              <a href="#"><img src="img/instagram-logo.png" width="30" height="30"/></a>
              <a href="#"><img src="img/gmail-logo.png" width="30" height="30"/></a>
            </div>
          </div>
        </div>
    </footer>

    <script>
        $( document ).on("ready",main);
        function main(){
          $("#IniciarSesion").on("click", Validar);
        }
        function CorrectoUsuario(){
          if($("#Usuario").hasClass("is-invalid")){
            $("#Usuario").addClass("is-valid");
            $("#Usuario").removeClass("is-invalid");
          }
          else{
            $("#Usuario").addClass("is-valid");
          }
        }

        function IncorrectoUsuario(){
          if($("#Usuario").hasClass("is-valid")){
            $("#Usuario").removeClass("is-valid");
            $("#Usuario").addClass("is-invalid");
          }
          else{
            $("#Usuario").addClass("is-invalid");
          }
        }

        function CorrectoContrasena(){
          if($("#Contrasena").hasClass("is-invalid")){
            $("#Contrasena").addClass("is-valid");
            $("#Contrasena").removeClass("is-invalid");
          }
          else{
            $("#Contrasena").addClass("is-valid");
          }
        }

        function IncorrectoContrasena(){
          if($("#Contrasena").hasClass("is-valid")){
            $("#Contrasena").removeClass("is-valid");
            $("#Contrasena").addClass("is-invalid");
          }
          else{
            $("#Contrasena").addClass("is-invalid");
          }
        }

        function Validar(){
          var tbUsuario = $("#Usuario").val();
          var tbContrasena = $("#Contrasena").val();

          if(tbUsuario != ""){
            CorrectoUsuario();
          }
          else{
            IncorrectoUsuario();
          }

          if(tbContrasena != ""){
            CorrectoContrasena();
          }
          else{
            IncorrectoContrasena();
          }
        }
  </script>
  <script type="text/javascript">$('#primero').popover(options)</script>
  <script type="text/javascript" src="js/bootstrap.min.js"></script>
  <script type="text/javascript" src="js/bootstrap.bundle.js"></script>
  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
</body>
</html>
