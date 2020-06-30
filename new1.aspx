<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="new1.aspx.cs" Inherits="WebApplication1.new1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p class="style1">
        匯率轉換練習</p>
    <p>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    <br />
</p>
<p>
    <asp:Button ID="btnOK" runat="server" Height="48px" onclick="btnOK_Click" 
        Text="確定轉換" Width="84px" />
</p>
<p>
</p>
</asp:Content>
