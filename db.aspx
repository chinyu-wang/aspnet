<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="db.aspx.cs" Inherits="WebApplication1.db" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/db.mdb" SelectCommand="SELECT [名稱] FROM [台中市景點資料]">
        </asp:AccessDataSource>
    </p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="AccessDataSource1" DataTextField="名稱" DataValueField="名稱" 
            Height="20px" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            Width="173px">
        </asp:DropDownList>
        <asp:Button ID="btnOK" runat="server" onclick="btnOK_Click" Text="OK" 
            Width="66px" />
    </p>
    <p>
        <asp:Label ID="lblRst" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
