<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="db2.aspx.cs" Inherits="WebApplication1.db2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    關鍵字:
    <asp:TextBox ID="txtKeyword" runat="server" Height="20px" Width="158px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" Text="查詢" Width="89px" />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" 
        BorderWidth="1px" CellPadding="4" DataSourceID="AccessDataSource1" 
        Width="914px" AutoGenerateColumns="False" DataKeyNames="景點ID">
        <Columns>
            <asp:BoundField DataField="景點ID" HeaderText="景點ID" ReadOnly="True" 
                SortExpression="景點ID" />
            <asp:BoundField DataField="名稱" HeaderText="景點名稱" SortExpression="名稱">
            <ItemStyle Width="150px" />
            </asp:BoundField>
            <asp:BoundField DataField="簡述" HeaderText="簡述" SortExpression="簡述" />
            <asp:BoundField DataField="鄉鎮市區" HeaderText="鄉鎮市區" SortExpression="鄉鎮市區" />
            <asp:BoundField DataField="地址" HeaderText="地址" SortExpression="地址" />
            <asp:BoundField DataField="電話" HeaderText="電話" SortExpression="電話" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/db.mdb" 
        
        SelectCommand="SELECT [景點ID], [名稱], [簡述], [鄉鎮市區], [地址], [電話] FROM [台中市景點資料] WHERE ([名稱] LIKE '%' + ? + '%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtKeyword" Name="名稱" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
    </asp:AccessDataSource>
</p>
</asp:Content>
