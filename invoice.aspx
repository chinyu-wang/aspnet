<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="invoice.aspx.cs" Inherits="WebApplication1.invoice" %>
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
        <br />
        <span class="style1">發票兌獎 109 1,2月</span></p>
    <p>
        發票號碼:<asp:TextBox ID="txtInvoice" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnOK" runat="server" Height="43px" onclick="btnOK_Click" 
            Text="對獎" Width="112px" />
    </p>
    <p>
        <asp:Label ID="lblRst" runat="server"></asp:Label>
    </p>
    <p>
    </p>
</asp:Content>
