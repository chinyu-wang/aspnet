<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="WebApplication1.update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

    .style4
    {
        font-size: xx-large;
    }

        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 99px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    &nbsp;<br class="style4" />
    <span class="style4">景點資料修改</span></p>
<p>
    &nbsp;</p>
    <table class="style2">
        <tr>
            <td class="style3">
                景點ID:</td>
            <td>
                <asp:TextBox ID="txt景點ID" runat="server"></asp:TextBox>
                <asp:Button ID="btnQry" runat="server" onclick="btnQry_Click" Text="查詢" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                名稱:</td>
            <td>
                <asp:TextBox ID="txt名稱" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                鄉鎮市區:</td>
            <td>
                <asp:TextBox ID="txt鄉鎮市區" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                地址:</td>
            <td>
                <asp:TextBox ID="txt地址" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p>
        <asp:Label ID="lblRst" runat="server"></asp:Label>
</p>
    <p>
        <asp:Button ID="btnOK" runat="server" Height="30px" onclick="btnOK_Click" 
            Text="確定修改" Width="80px" />
</p>
    <p>
</p>
<p>
</p>
</asp:Content>
