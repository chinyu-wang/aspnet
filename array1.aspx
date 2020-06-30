<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="array1.aspx.cs" Inherits="WebApplication1.array1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="btnOK" runat="server" Height="34px" onclick="btnOK_Click" 
        Text="OK" Width="86px" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
