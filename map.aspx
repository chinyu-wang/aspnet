<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="map.aspx.cs" Inherits="WebApplication1.map" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<meta charset="utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1.0">

<link rel="shortcut icon" type="image/x-icon" href="docs/images/favicon.ico" />

   <link rel="stylesheet" href="https://unpkg.com/leaflet@1.0.3/dist/leaflet.css" integrity="sha512-07I2e+7D8p6he1SIM+1twR5TIrhUQn9+I6yjqD53JQjFiMf8EtC93ty0/5vJTZGF8aAocvHYNEDJajGdNx1IsQ==" crossorigin=""/>
    <script src="https://unpkg.com/leaflet@1.0.3/dist/leaflet.js" integrity="sha512-A7vV8IFfih/D732iSSKi20u/ooOfj/AGehOKq0f4vLT1Zr2Y+RX7C+w8A1gaSasGtRUZpF/NZgzSAu4/Gc41Lg==" crossorigin=""></script>

    <asp:Button ID="btnMap" runat="server" onclick="btnMap_Click" Text="Show Map" />

    <asp:Button ID="btnConvert" runat="server" onclick="btnConvert_Click" 
        Text="Convert Address to Lat,Lng" />
    <br />
    <asp:TextBox ID="txtAddress" runat="server" Width="289px"></asp:TextBox>
    <asp:Label ID="lblRst" runat="server"></asp:Label>

<div id="mapid" style="width: 600px; height: 400px;">
    <br />
    <br />
    </div>
<script>
    function ShowMyMap(lat, lng, msg) {
        var mymap = L.map('mapid').setView([lat, lng], 6);
        //51.505, -0.09

        var marker = L.marker([lat, lng]).addTo(mymap);
        marker.bindPopup(msg);


        L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoibWFwYm94IiwiYSI6ImNpejY4NXVycTA2emYycXBndHRqcmZ3N3gifQ.rJcFIG214AriISLbB6B5aw', {
            maxZoom: 18,
            attribution: 'Map data &copy; <a href="http://openstreetmap.org">OpenStreetMap</a> contributors, ' +
        '<a href="http://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, ' +
        'Imagery © <a href="http://mapbox.com">Mapbox</a>',
            id: 'mapbox.streets'
        }).addTo(mymap);
    }
</script>


</asp:Content>
