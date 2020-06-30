<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="new3.aspx.cs" Inherits="WebApplication1.new3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
</p>
<p>
    USD:
    <asp:TextBox ID="txtUSD" runat="server"></asp:TextBox>
</p>
<p>
    Rate:
    <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="lblDate" runat="server"></asp:Label>
</p>
<p>
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="btnOK" runat="server" Height="47px" onclick="btnOK_Click" 
        Text="開始計算" Width="112px" />
</p>
<p>
    <br />
</p>
</asp:Content>
