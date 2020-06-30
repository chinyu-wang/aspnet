<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="db1.aspx.cs" Inherits="WebApplication1.db1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/db.mdb" 
            SelectCommand="SELECT DISTINCT [鄉鎮市區] FROM [台中市景點資料] ORDER BY [鄉鎮市區]">
        </asp:AccessDataSource>
    </p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="AccessDataSource1" DataTextField="鄉鎮市區" DataValueField="鄉鎮市區">
        </asp:DropDownList>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
            BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
            DataKeyNames="景點ID" DataSourceID="AccessDataSource2" GridLines="Horizontal" 
            Height="315px" Width="913px">
            <Columns>
                <asp:BoundField DataField="景點ID" HeaderText="景點ID" ReadOnly="True" 
                    SortExpression="景點ID" />
                <asp:BoundField DataField="名稱" HeaderText="名稱" SortExpression="名稱" />
                <asp:BoundField DataField="簡述" HeaderText="簡述" SortExpression="簡述" />
                <asp:BoundField DataField="鄉鎮市區" HeaderText="鄉鎮市區" SortExpression="鄉鎮市區" />
                <asp:BoundField DataField="地址" HeaderText="地址" SortExpression="地址" />
                <asp:BoundField DataField="東經" HeaderText="東經" SortExpression="東經" />
                <asp:BoundField DataField="電話" HeaderText="電話" SortExpression="電話" />
                <asp:BoundField DataField="北緯" HeaderText="北緯" SortExpression="北緯" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerSettings FirstPageText="第一頁" LastPageText="最後頁" 
                Mode="NextPreviousFirstLast" NextPageText="下頁" Position="TopAndBottom" 
                PreviousPageText="上頁" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
    </p>
    <p>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
            DataFile="~/App_Data/db.mdb" 
            SelectCommand="SELECT [景點ID], [名稱], [簡述], [鄉鎮市區], [地址], [東經], [電話], [北緯] FROM [台中市景點資料] WHERE ([鄉鎮市區] = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="鄉鎮市區" 
                    PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
    </p>
</asp:Content>
