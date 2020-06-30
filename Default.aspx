<%@ Page Title="首頁" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 54px;
    }
    .style3
    {
        font-size: x-large;
    }
</style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        &nbsp;</p>
<p class="style3">
    點單練習</p>
<p>
    <table class="style1">
        <tr>
            <td class="style2">
                紅茶:</td>
            <td>
                <asp:TextBox ID="txtTea1" runat="server"  ></asp:TextBox>
                杯</td>
        </tr>
        <tr>
            <td class="style2">
                綠茶:
            </td>
            <td>
                <asp:TextBox ID="txtTea2" runat="server"></asp:TextBox>
                杯</td>
        </tr>
        <tr>
            <td class="style2">
                青茶:
            </td>
            <td>
                <asp:TextBox ID="txtTea3" runat="server"></asp:TextBox>
                杯</td>
        </tr>
    </table>
    <br />
&nbsp;<asp:Label ID="lblMsg" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="btnOK" runat="server" Height="36px" onclick="btnOK_Click" 
        Text="確定點餐" Width="90px" />
</p>
<p>
    &nbsp;</p>
<p>
</p>



</asp:Content>

