<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="id-check.aspx.cs" Inherits="WebApplication1.id_check" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p class="style1">
        身分證檢查程式</p>
    <p>
        請輸入身分證字號:
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblRst" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="btnOK" runat="server" Height="35px" onclick="btnOK_Click" 
        Text="Check" Width="92px" />
</p>
<p>
</p>
<p>
</p>
</asp:Content>
