<%@ Page Title="" Language="C#" MasterPageFile="~/Src/BE/_Admin.Master" AutoEventWireup="true" CodeBehind="CategoryManager.aspx.cs" Inherits="TamViet.Src.BE.CategoryManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader notab">
            <h2 class="pagetitle">Quản lý thông tin về các danh mục</h2>
            <span class="pagedesc"><b>"Sub Category"</b> là menu con,<b>"Danh mục cha"</b> là danh mục chứa menu con đó</span>
            <br />
            <span class="pagedesc">Click vào checkbox ở <b>"Sub Category"</b> hiển thị danh sách danh mục cha để lựa chọn</span>
            
        </div><!--pageheader-->
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <div class="contenttitle2">
            <h3>Quản lý danh mục</h3>
        </div>
        <asp:DataGrid CssClass="grd-stdtable" runat="server" ID="dtgCategory" OnItemCommand="dtgCategory_ItemCommand" AutoGenerateColumns="false" AllowPaging="true" 
            PageSize="10" ShowFooter="true" ShowHeader="true" OnItemDataBound="dtgCategory_ItemDataBound" OnPageIndexChanged="dtgCategory_PageIndexChanged">
            <Columns>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblId" Text='<%#Eval("Id") %>' Visible="false"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Tên danh mục</HeaderTemplate>
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtCatName" Text='<%#Eval("Name") %>'></asp:TextBox>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtCatName"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Active</HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox runat="server" ID="chkActive" Checked='<%#(bool)Eval("Active") %>' />
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Is Sub Category</HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox runat="server" ID="chkSubCat" OnCheckedChanged="chkSubCat_CheckedChanged" AutoPostBack="true" />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:CheckBox runat="server" ID="chkSubCat" OnCheckedChanged="chkSubCat_CheckedChanged" AutoPostBack="true" />
                    </FooterTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Danh mục cha</HeaderTemplate>
                    <ItemTemplate>
                        <asp:DropDownList runat="server" ID="ddlCat" />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList runat="server" ID="ddlCat" />
                    </FooterTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:ImageButton CssClass="button-dg" ID="btnUpdate" runat="server"
                        CommandName="cmdUpdate" ImageUrl="~/Images/Event/edit.png" />
                        <asp:ImageButton CssClass="button-dg" ID="btnDelete" runat="server"
                        CommandName="cmdDelete" ImageUrl="~/Images/Event/delete.png" />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:ImageButton CssClass="button-dg" ID="btnAdd" runat="server"
                        CommandName="cmdAdd" ImageUrl="~/Images/Event/add.png" />
                    </FooterTemplate>
                </asp:TemplateColumn>
            </Columns>
            <PagerStyle Mode="NumericPages" CssClass="pager-grid" />
        </asp:DataGrid>
    </div>
</asp:Content>
