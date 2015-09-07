<%@ Page Title="" Language="C#" MasterPageFile="~/Src/BE/_Admin.Master" AutoEventWireup="true" CodeBehind="Support.aspx.cs" Inherits="TamViet.Src.BE.Support" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <div class="contenttitle2">
            <h3>Thông tin mục hỗ trợ trực tuyến</h3>
        </div>
        <asp:DataGrid runat="server" ID="dtgSupport" ShowFooter="true" ShowHeader="true" AutoGenerateColumns="false"
            OnItemDataBound="dtgSupport_ItemDataBound" OnItemCommand="dtgSupport_ItemCommand" OnPageIndexChanged="dtgSupport_PageIndexChanged"
            AllowPaging="true" PageSize="10">
            <Columns>
                <asp:TemplateColumn Visible="false">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblId" Text='<%#Eval("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Tên hiển thị</HeaderTemplate>
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtName" Text='<%#Eval("Name") %>'></asp:TextBox>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Nickname</HeaderTemplate>
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtAddress" Text='<%#Eval("Address") %>'></asp:TextBox>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtAddress"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Type</HeaderTemplate>
                    <ItemTemplate>
                        <asp:DropDownList runat="server" ID="ddlType">
                            <asp:ListItem Value="0">Skype</asp:ListItem>
                            <asp:ListItem Value="1">Yahoo Messenger</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList runat="server" ID="ddlType">
                            <asp:ListItem Value="0">Skype</asp:ListItem>
                            <asp:ListItem Value="1">Yahoo Messenger</asp:ListItem>
                        </asp:DropDownList>
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
