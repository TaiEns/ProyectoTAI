<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calis.aspx.cs" Inherits="TainEns.calis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1 class="text-center">Negocios</h1>
        <asp:GridView ID="GridView1" runat="server"
         OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
              OnRowDeleting="GridView1_RowDeleting" AutoGenerateColumns="False" DataKeyNames="IdNegocios" CssClass="table table-hover">
            <Columns>
                <asp:BoundField DataField="NombreNegocio" HeaderText="Nombre" />
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button" >                
                <ControlStyle CssClass="btn btn-primary" />
                </asp:CommandField>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" >
                
                <ControlStyle CssClass="btn btn-primary" />
                </asp:CommandField>
                
            </Columns>
 
            <HeaderStyle CssClass="thead-dark" />
 
        </asp:GridView>
        <asp:Label ID="LabelMensaje" runat="server" Text="Label" Visible="false"></asp:Label>
    </div>
    
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
