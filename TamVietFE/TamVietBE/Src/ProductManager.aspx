<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_Admin.Master" AutoEventWireup="true" CodeBehind="ProductManager.aspx.cs" Inherits="TamVietBE.Src.ProductManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader notab">
            <h2 class="pagetitle">Quản lý thông tin về các sản phẩm</h2>
            <span class="pagedesc"></span>
            
        </div><!--pageheader-->
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <div class="contenttitle2">
            <h3>Product Manager</h3>
        </div>
        <br />
        <%--<button class="stdbtn btn_orange">Thêm mới sản phẩm</button>--%>
        <asp:Button runat="server" ID="btnAddNew" CssClass="stdbtn btn_orange" Text="Thêm mới sản phẩm"/>
        <br />
        <br />
        <asp:DataGrid runat="server" AutoGenerateColumns="false" ID="dtgProduct" CssClass="grd-stdtable" PageSize="15" ShowHeader="true"
            OnItemDataBound="dtgProduct_ItemDataBound" OnItemCommand="dtgProduct_ItemCommand" OnPageIndexChanged="dtgProduct_PageIndexChanged">
            <Columns>
                <asp:TemplateColumn Visible="false">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblId" Visible="false" Text='<%#Eval("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Tên sản phẩm</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblName" Text='<%#Eval("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Danh mục</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblCategory" Text='<%#Eval("CatName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Active</HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox runat="server" Enabled="false" Checked='<%#(bool)Eval("Active") %>'/>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Edit</HeaderTemplate>
                    <ItemTemplate>
                        <asp:HyperLink runat="server" CssClass="underline-blue" ID="lnkEditProduct"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Amendment</HeaderTemplate>
                    <ItemTemplate>
                        <asp:ImageButton CssClass="button-dg" ID="btnDelete" runat="server"
                        CommandName="cmdDelete" ImageUrl="~/Images/Event/delete.png" />
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <PagerStyle Mode="NumericPages" CssClass="pager-grid" />
        </asp:DataGrid>
    </div>
</asp:Content>
