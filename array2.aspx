<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="array2.aspx.cs" Inherits="WebApplication1.array2" %>
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
        題目: 業務員業績計算</p>
<p>
        <br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </p>
    <p>
    <asp:Button ID="btnOK" runat="server" Height="34px" onclick="btnOK_Click" 
        Text="OK" Width="86px" />
    </p>
    <p>
    </p>
</asp:Content>
