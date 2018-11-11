<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificar_negocio.aspx.cs" Inherits="TainEns.paginas.Cliente.Negocios.modificar_negocio" %>

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
    <title>Modificar Negocio</title>
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
			  <button class="btn btn-secondary dropdown-toggle azuloscuro usuario" type="button" id="dropdownMenu2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
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
         <div class="shadow-lg p-3 mb-5 bg-white rounded">
          <div class="text-center mb-4">
            <h1 class="h3 mb-3 font-weight-bold">Agregar Negocio</h1>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <label for="Nombre">Nombre</label>
              <asp:TextBox ID="Nombre" runat="server" class="form-control" placeholder="Nombre" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="Nombre" placeholder="Nombre" />-->
            </div>
            <div class="col-md-4 mb-3">
              <label for="RFC">RFC</label>
                <asp:TextBox ID="RFC" runat="server" class="form-control" placeholder="RFC"></asp:TextBox>
              <!--<input type="text" class="form-control" id="RFC" placeholder="RFC" />-->
            </div>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <label for="Calle">Dirección</label>
              <asp:TextBox ID="Calle" runat="server" class="form-control" placeholder="Calle" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="Nombre" placeholder="Nombre" />-->
            </div>
            <div class="col-md-4 mb-3">
                <asp:TextBox ID="ColFrac" runat="server" class="form-control" placeholder="Colonia/Fraccionamiento" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="RFC" placeholder="RFC" />-->
            </div>
          </div>
          <div class="form-row form-input">
            <div class="col-md-4 mb-3">
              <asp:TextBox ID="CP" runat="server" class="form-control" placeholder="C.P" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="Nombre" placeholder="Nombre" />-->
            </div>
            <div class="col-md-4 mb-3">
                <asp:TextBox ID="Numero" runat="server" class="form-control" placeholder="#" required></asp:TextBox>
              <!--<input type="text" class="form-control" id="RFC" placeholder="RFC" />-->
            </div>
          </div>
          <div class="form-row form-input">
              <div class="col-md-4">
                  <div class="row">
                      <label for="Tipo">Tipo</label>
                      <asp:DropDownList ID="Tipo" runat="server" class="form-control form-control-lg" >
                          <asp:ListItem Value="Mini Mercado">Mini mercado</asp:ListItem>
                          <asp:ListItem Value="Fruteria">Fruteria</asp:ListItem>
                          <asp:ListItem Value="Fruteria">Carniceria</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                  <div class="row">
                      <label for="Telefono">Telefono</label>
                    <asp:TextBox ID="Telefono" runat="server" class="form-control" placeholder="(---)--- ----"></asp:TextBox>
                  </div>
              </div>
              <div class="col-md-7 ">
                  <label for="EntradaL">Horario</label>
                  <div class="row">
                      <div class="col horario">
                          Lunes 
                          <asp:DropDownList ID="EntradaL" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          a.m
                      </div> a 
                      <div class="col horario">
                          <asp:DropDownList ID="SalidaL" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          p.m
                    </div>
                </div>
                  <div class="row">
                      <div class="col horario">
                          Martes 
                          <asp:DropDownList ID="EntradaMa" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          a.m
                      </div> a 
                      <div class="col horario">
                          <asp:DropDownList ID="SalidaMa" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          p.m
                    </div>
                </div>
                 <div class="row">
                      <div class="col horario">
                          Miercoles 
                          <asp:DropDownList ID="EntradaMi" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          a.m
                      </div> a 
                      <div class="col horario">
                          <asp:DropDownList ID="SalidaMi" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          p.m
                    </div>
                </div>
                 <div class="row">
                      <div class="col horario">
                          Jueves 
                          <asp:DropDownList ID="EntradaJ" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          a.m
                      </div> a 
                      <div class="col horario">
                          <asp:DropDownList ID="SalidaJ" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          p.m
                    </div>
                </div>
                 <div class="row">
                      <div class="col horario">
                          Viernes 
                          <asp:DropDownList ID="EntradaV" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          a.m
                      </div> a 
                      <div class="col horario">
                          <asp:DropDownList ID="SalidaV" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          p.m
                    </div>
                </div>
                 <div class="row">
                      <div class="col horario">
                          Sábado 
                          <asp:DropDownList ID="EntradaS" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          a.m
                      </div> a 
                      <div class="col horario">
                          <asp:DropDownList ID="SalidaS" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          p.m
                    </div>
                </div>
                 <div class="row">
                      <div class="col horario">
                          Domingo 
                          <asp:DropDownList ID="EntradaD" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          a.m
                      </div> a 
                      <div class="col horario">
                          <asp:DropDownList ID="SalidaD" runat="server" class="" >
                              <asp:ListItem Value="0">--:--</asp:ListItem>
                              <asp:ListItem Value="1">01:00</asp:ListItem>
                              <asp:ListItem Value="2">02:00</asp:ListItem>
                              <asp:ListItem Value="3">03:00</asp:ListItem>
                              <asp:ListItem Value="4">04:00</asp:ListItem>
                              <asp:ListItem Value="5">05:00</asp:ListItem>
                              <asp:ListItem Value="6">06:00</asp:ListItem>
                              <asp:ListItem Value="7">07:00</asp:ListItem>
                              <asp:ListItem Value="8">08:00</asp:ListItem>
                              <asp:ListItem Value="9">09:00</asp:ListItem>
                              <asp:ListItem Value="10">10:00</asp:ListItem>
                              <asp:ListItem Value="11">11:00</asp:ListItem>
                              <asp:ListItem Value="12">12:00</asp:ListItem>
                          </asp:DropDownList>
                          p.m
                    </div>
                </div>
              </div>
          </div>
          <div class="form-row form-input">
              <div class="col-md-4 mb-3">
                    <asp:Button ID="Modificar" runat="server" Text="Modificar" class="btn btn-lg btn-primary btn-block azuloscuro botones" data-toggle="modal"  data-target="#exampleModal" OnClick="Modificar_Click"/>
              </div>
              <div class="col-md-4 mb-3">
                    <a id="Cancelar" class="btn btn-lg btn-primary btn-block azuloscuro botones cancelar" href="mis_negocios.aspx" style="margin-top: 0px;">Cancelar</a>
              </div>
           </div>
        </div>
        <!-- Modal -->
        <asp:Panel ID="pnModal" runat="server">
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h2 class="modal-title" id="exampleModalLabel" style="text-align: center;"><asp:Label runat="server" ID="lblTituloModal" Text="Fallido"></asp:Label></h2>
                        </div>
                        <div class="modal-body text-center">
                            <asp:Label runat="server" ID="lblMensajeModal" Text="Campos obligatorios no completados."></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </asp:Panel>
        <asp:Panel ID="Panel1" runat="server">
            <div class="modal fade" id="modal2" tabindex="-1" role="dialog" aria-labelledby="modal2" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h2 class="modal-title" id="titulomodal2" style="text-align: center;"><asp:Label runat="server" ID="Label1" Text="Agregado"></asp:Label></h2>
                        </div>
                        <div class="modal-body text-center">
                            <asp:Label runat="server" ID="Label2" Text="Se ha enviado la solicitud. En cuanto sea aceptada tu negocio estara disponible."></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </asp:Panel>
    </form>
    <script>
    $( document ).on("ready",main);
    function main(){
      var cont = 0;
      $("#Modificar").on("click", Validar);
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
          var tbCalle = $("#Calle").val();
          var tbColonia = $("#ColFrac").val();
          var tbCodigo = $("#CP").val();
          var tbNumero = $("#Numero").val();
          var ddlTipo = $("#Tipo").val();
          var cont = 0;

          if(tbNombre != ""){
            Correcto("#Nombre");
            cont++;
          }
          else{
            Incorrecto("#Nombre");
          }
        if (tbCalle != "") {
            Correcto("#Calle");
            cont++;
          }
          else{
            Incorrecto("#Calle");
        }
        if (tbColonia != "") {
            Correcto("#ColFrac");
            cont++;
          }
          else{
            Incorrecto("#ColFrac");
        }
        if (tbCodigo != "") {
            Correcto("#CP");
            cont++;
          }
          else{
            Incorrecto("#CP");
        }
        if (tbNumero != "") {
            Correcto("#Numero");
            cont++;
          }
          else{
            Incorrecto("#Numero");
        }

        if (ddlTipo != "") {
            Correcto("#Tipo");
          }
          else{
            Incorrecto("#Tipo");
        }
        
        
        if(cont == 5){
            $("#Modificar").attr("data-target", "#modal2");
        }
        
    }
  </script>
    <script type="text/javascript" src="../../../js/bootstrap.min.js"></script>
    <script type="text/javascript" src="../../../js/bootstrap.bundle.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>

</body>
</html>
