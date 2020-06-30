<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="city.aspx.cs" Inherits="WebApplication1.city" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <asp:Button ID="btnDist" runat="server" Height="35px" onclick="btnDist_Click" 
        Text="里程表" Width="120px" />
        <asp:Button ID="btnPrice" runat="server" Height="35px" onclick="btnPrice_Click" 
            Text="票價表" Width="120px" />
        <asp:Button ID="btnSale" runat="server" Height="35px" Text="購票" Width="120px" 
            onclick="btnSale_Click" />
</p>
    <asp:Panel ID="Panel1" runat="server" BackColor="#FFFF66" Height="192px">
        <asp:Label ID="lblRst" runat="server"></asp:Label>
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server" BackColor="#99CCFF" Height="211px" 
        Visible="False">
        <br />
        出發城市:
        <asp:DropDownList ID="ddlStart" runat="server">
            <asp:ListItem Value="台北">台北</asp:ListItem>
            <asp:ListItem Value="桃園">桃園</asp:ListItem>
            <asp:ListItem Value="新竹">新竹</asp:ListItem>
            <asp:ListItem>台中</asp:ListItem>
            <asp:ListItem>嘉義</asp:ListItem>
            <asp:ListItem>台南</asp:ListItem>
            <asp:ListItem>高雄</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        目的城市:
        <asp:DropDownList ID="ddlStop" runat="server">
            <asp:ListItem>台北</asp:ListItem>
            <asp:ListItem>桃園</asp:ListItem>
            <asp:ListItem>新竹</asp:ListItem>
            <asp:ListItem>台中</asp:ListItem>
            <asp:ListItem>嘉義</asp:ListItem>
            <asp:ListItem>台南</asp:ListItem>
            <asp:ListItem>高雄</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        張數:
        <asp:DropDownList ID="ddlNum" runat="server">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Height="31px" onclick="Button1_Click" 
            Text="確定" Width="92px" />
        <br />
        <br />
        <asp:Label ID="lblRst1" runat="server"></asp:Label>
    </asp:Panel>
<p>
    &nbsp;</p>
<p>
</p>
</asp:Content>
