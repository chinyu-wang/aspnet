<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="loop.aspx.cs" Inherits="WebApplication1.loop" %>
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
        <br />
        <span class="style1">計算總和</span></p>
    <p>
        請輸入一個正整數:
        <asp:TextBox ID="txtNun" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblRst" runat="server" style="font-size: x-large"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnOK" runat="server" Height="36px" onclick="btnOK_Click" 
            Text="OK" Width="78px" />
    </p>
    <p>
        &nbsp;</p>
    <p class="style1">
        99乘法表</p>
    <p class="style1">
        <asp:Label ID="lbl99" runat="server" Font-Size="X-Large"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btn99" runat="server" Height="39px" onclick="btn99_Click" 
            Text="OK" Width="77px" />
    </p>
    <p>
    </p>
</asp:Content>
