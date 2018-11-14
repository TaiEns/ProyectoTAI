<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="olvide_contrasena.aspx.cs" Inherits="TainEns.paginas.Olvide_Contrasena.olvide_contrasena" %>

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
    <title>Olvide Contraseña</title>
</head>
<body>
    <form id="form1" runat="server" class="form-signin">
        <asp:Panel ID="pFase1" runat="server">
            <div class="shadow-lg p-3 mb-5 bg-white rounded">
                <div class="text-center mb-4">
                    <img class="mb-4" src="../../img/sadface.jpg" alt="" width="72" height="72"/>
                    <h1 class="h3 mb-3 font-weight-normal">Recuperar Contraseña</h1>
                    <p>Se enviara un código de seguridad a su correo para restablecer su contraseña</p>
                </div>
                <div class="form-label-group">
                    <asp:TextBox ID="inputEmail" runat="server" class="form-control" placeholder="Correo"></asp:TextBox>
                    <label for="inputEmail">Correo</label>
                </div>
                <asp:Button ID="btnEnviarCodigo" runat="server" class="btn btn-lg btn-primary btn-block" Text="Enviar" OnClick="btnEnviarCodigo_Click" />
            </div>
        </asp:Panel>

        <asp:Panel ID="pFase2" runat="server">
            <div class="shadow-lg p-3 mb-5 bg-white rounded">
                <div class="text-center mb-4">
                    <img class="mb-4" src="../../img/sorprise.jpg" alt="" width="72" height="72"/>
                    <h1 class="h3 mb-3 font-weight-normal">Recuperar Contraseña</h1>
                    <p>Escribe el código de seguridad</p>
                </div>
                <div class="form-label-group">
                    <asp:TextBox ID="tbCodigo" runat="server" class="form-control" placeholder="Codigo de Seguridad"></asp:TextBox>
                    <label for="tbCodigo">Codigo de Seguridad</label>
                </div>
                <asp:Button ID="btnConfirmar" runat="server" class="btn btn-lg btn-primary btn-block" Text="Confirmar" OnClick="btnConfirmar_Click" />
            </div>
        </asp:Panel>

        <asp:Panel ID="pFase3" runat="server">
            <div class="shadow-lg p-3 mb-5 bg-white rounded">
                <div class="text-center mb-4">
                    <img class="mb-4" src="../../img/happyface.jpg" alt="" width="72" height="72"/>
                    <h1 class="h3 mb-3 font-weight-normal">Recuperar Contraseña</h1>
                    <p>Elige una nueva contraseña</p>
                </div>
                <div class="form-label-group">
                    <asp:TextBox ID="inputPassword" runat="server" class="form-control" placeholder="Nueva Contraseña" type="password"></asp:TextBox>
                    <label for="inputPassword">Nueva Contraseña</label>
                </div>
                <div class="form-label-group">
                    <asp:TextBox ID="tbConfirmarContra" runat="server" class="form-control" placeholder="Confirmar" type="password"></asp:TextBox>
                    <label for="tbConfirmarContra">Confirmar</label>
                </div>
                <asp:Button ID="btnCambiar" runat="server" class="btn btn-lg btn-primary btn-block" Text="Cambiar" OnClick="btnCambiar_Click" />
            </div>
        </asp:Panel>
    </form>

    <script type="text/javascript" src="../../../js/bootstrap.min.js"></script>
    <script type="text/javascript" src="../../../js/bootstrap.bundle.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>

</body>
</html>
