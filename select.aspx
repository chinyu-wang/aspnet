<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="select.aspx.cs" Inherits="WebApplication1.select" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnOK" runat="server" Height="35px" onclick="btnOK_Click" 
        Text="Select 資料" Width="122px" />
</p>
<p>
    <asp:Label ID="lblRst" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
