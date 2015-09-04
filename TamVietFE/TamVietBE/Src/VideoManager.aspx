<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_Admin.Master" AutoEventWireup="true" CodeBehind="VideoManager.aspx.cs" Inherits="TamVietBE.Src.VideoManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <div class="contenttitle2">
            <h3>Quản lý video hiển thị</h3>
        </div>
        <asp:DataGrid runat="server" ID="dtgVideo" ShowFooter="true" ShowHeader="true" AutoGenerateColumns="false"
            OnItemCommand="dtgVideo_ItemCommand" OnPageIndexChanged="dtgVideo_PageIndexChanged"
            AllowPaging="true" PageSize="10">
            <Columns>
                <asp:TemplateColumn Visible="false">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="lblId" Text='<%#Eval("Id") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Url</HeaderTemplate>
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtUrl" Text='<%#Eval("Url") %>'></asp:TextBox>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtUrl"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Mô tả</HeaderTemplate>
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtDetail" Text='<%#Eval("Detail") %>'></asp:TextBox>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtDetail"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Active</HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox runat="server" ID="chkActive" Checked='<%#(bool)Eval("Active") %>' />
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <HeaderTemplate>Amendment</HeaderTemplate>
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
        </asp:DataGrid>
    </div>
</asp:Content>
