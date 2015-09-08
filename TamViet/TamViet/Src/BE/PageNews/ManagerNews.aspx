<%@ Page Title="" Language="C#" MasterPageFile="~/Src/BE/_Admin.Master" AutoEventWireup="true" CodeBehind="ManagerNews.aspx.cs" Inherits="TamViet.Src.BE.PageNews.ManagerNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <div class="contenttitle2">
            <h3>Quản lý tin tức</h3>
        </div>
        <br />
        <asp:Button runat="server" ID="btnAddNew" OnClick="btnAddNew_Click" CssClass="stdbtn btn_orange" Text="Thêm mới sản phẩm"/>
        <br />
        <br />
        <asp:DataGrid runat="server" ID="dtgNews" AutoGenerateColumns="false" AllowPaging="true" PageSize="15" OnItemDataBound="dtgNews_ItemDataBound"
            OnItemCommand="dtgNews_ItemCommand" ShowFooter="false" ShowHeader="true" OnPageIndexChanged="dtgNews_PageIndexChanged">
            <Columns>
                <asp:TemplateColumn Visible="false">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblId" Text='<%#Eval("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Tiêu đề</HeaderTemplate>
                    <ItemTemplate>
                        <asp:HyperLink Font-Underline="true" Font-Bold="true" runat="server" ID="lnkTitle" NavigateUrl='<%# "~/Src/BE/PageNews/EditNews.aspx?id=" + Eval("Id")%>'><%#Eval("Title") %></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Thể loại</HeaderTemplate>
                    <ItemTemplate>
                        <asp:DropDownList runat="server" ID="ddlType">
                            <asp:ListItem Value="1">Tin tức công ty</asp:ListItem>
                            <asp:ListItem Value="2">Tin tức y tế</asp:ListItem>
                            <asp:ListItem Value="3">Kiến thức y học</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Ngày cập nhật</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblDate" Text='<%#Eval("DateInsert") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:HyperLink runat="server" Font-Underline="true" Font-Bold="true" NavigateUrl='<%# "~/Src/News.aspx?id=" + Eval("Id")%>' >Preview</asp:HyperLink>
                        <asp:ImageButton CssClass="button-dg" ID="btnDelete" runat="server"
                        CommandName="cmdDelete" ImageUrl="~/Images/Event/delete.png" />
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <PagerStyle Mode="NumericPages" CssClass="pager-grid" />
        </asp:DataGrid>
    </div>
</asp:Content>
