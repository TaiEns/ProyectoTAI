<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aprobar_negocio.aspx.cs" Inherits="TainEns.paginas.Administrador.Solicitudes.aprobar_negocio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="lblmsn" Text=""></asp:Label>
        </div>
    </form>
    <script src='https://maps.googleapis.com/maps/api/js?v=3.exp&key=AIzaSyC37Xjlxe98oTy5mk9Y_M3pHRFt5IletPA'></script>
    <div style='overflow:hidden;height:400px;width:520px;'><div id='gmap_canvas' style='height:400px;width:520px;'></div>
        <style>#gmap_canvas img{max-width:none!important;background:none!important}</style>

    </div> 
    <a href='http://maps-website.com/es'>En maps-generator.com</a> 
    <script type='text/javascript' src='https://embedmaps.com/google-maps-authorization/script.js?id=2330b2daaf53b726d182c9384953561ab0987381'></script>
    <script type='text/javascript'>
        function init_map() {
            var myOptions = {
                zoom: 14, center: new google.maps.LatLng(31.9000839, -116.5752981), mapTypeId: google.maps.MapTypeId.ROADMAP
            }; map = new google.maps.Map(document.getElementById('gmap_canvas'), myOptions);
            marker = new google.maps.Marker({ map: map, position: new google.maps.LatLng(31.9000839, -116.5752981) });
            infowindow = new google.maps.InfoWindow({ content: '<strong>Yo</strong><br>Puerto la paz<br>22813 Ensenada<br>' });
            google.maps.event.addListener(marker, 'click', function () {
                infowindow.open(map, marker);
            }); infowindow.open(map, marker);
        } google.maps.event.addDomListener(window, 'load', init_map);

    </script>
</body>
</html>
