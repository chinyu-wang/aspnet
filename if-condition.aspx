<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="if-condition.aspx.cs" Inherits="WebApplication1.if_condition" %>
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
    <span class="style1" 
        style="font-family: 標楷體; mso-ascii-font-family: Arial; mso-fareast-font-family: 標楷體; mso-bidi-font-family: +mn-cs; mso-ascii-theme-font: minor-latin; mso-fareast-theme-font: minor-fareast; mso-bidi-theme-font: minor-bidi; color: black; mso-color-index: 1; language: zh-TW; text-combine: letters; mso-style-textfill-type: solid; mso-style-textfill-fill-themecolor: text1; mso-style-textfill-fill-color: black; mso-style-textfill-fill-alpha: 100.0%">
    以身高來判斷購買全票或半票</span></p>
<p>
    身高:
    <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnOK" runat="server" Height="36px" onclick="btnOK_Click" 
        Text="OK" Width="83px" />
</p>
<p>
    &nbsp;</p>
<p>
    <span style="font-size: 24.0pt; font-family: 標楷體; mso-ascii-font-family: Arial; mso-fareast-font-family: 標楷體; mso-bidi-font-family: +mn-cs; mso-ascii-theme-font: minor-latin; mso-fareast-theme-font: minor-fareast; mso-bidi-theme-font: minor-bidi; color: black; mso-color-index: 1; language: zh-TW; text-combine: letters; mso-style-textfill-type: solid; mso-style-textfill-fill-themecolor: text1; mso-style-textfill-fill-color: black; mso-style-textfill-fill-alpha: 100.0%">
    以年齡判斷搭乘公車的票種</span></p>
<p>
    年齡:
    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnAge" runat="server" Height="35px" onclick="btnAge_Click" 
        Text="OK" Width="82px" />
</p>
<p>
    <asp:Label ID="lblRst" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
</asp:Content>
