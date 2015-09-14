<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrNews.ascx.cs" Inherits="TamViet.Src.BE.PageNews.usrNews" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
        <div class="contenttitle2">
            <h3><asp:Literal runat="server" ID="litTitle"></asp:Literal></h3>
        </div>
        <div class="stdform stdform2">
            <p>
                <label>Tên tiêu đề</label>
                <span class="field"><asp:TextBox runat="server" ID="txtTitle" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Thể loại</label>
                <span class="field">
                    <asp:DropDownList runat="server" ID="ddlType">
                        <asp:ListItem Value="1">Tin tức công ty</asp:ListItem>
                        <asp:ListItem Value="2">Tin tức y tế</asp:ListItem>
                        <asp:ListItem Value="3">Kiến thức y học</asp:ListItem>
                    </asp:DropDownList>
                </span>
            </p>
            <asp:Panel runat="server" ID="pnlImg" Visible="false">
            <p>
                <label>Hình ảnh</label>
                <span class="field"><asp:Image runat="server" ID="imgNews" Height="150px" /></span>
            </p>
            </asp:Panel>
            <asp:Panel runat="server" ID="pnlUpload" Visible="true">
                <p>
                    <label><asp:Literal runat="server" ID="litText"></asp:Literal></label>
                    <span class="field">Đường dẫn <asp:TextBox runat="server" ID="txtImg" CssClass="smallinput" placeholder="VD:https://images.google.com/"></asp:TextBox> Hoặc upload ảnh <asp:FileUpload runat="server" ID="fileUpload" /></span>
                </p>
            </asp:Panel>
            <p>
                <label>Active</label>
                <span class="field"><asp:CheckBox runat="server" ID="chkActive" /></span>
            </p>
            <p>
                <label>Nội dung</label>
                <span class="field"><CKEditor:CKEditorControl runat="server" ID="txtContent" BasePath="/js/plugins/ckeditor/" Height="200px"></CKEditor:CKEditorControl></span>
            </p>
            <p class="stdformbutton">
                <asp:Button runat="server" ID="btnSubmitNews" CssClass="submit radius2" Text="Thêm mới" OnClick="btnSubmitNews_Click"/>
                <asp:Button runat="server" ID="btnEditNews" CssClass="submit radius2" Text="Cập nhật" OnClick="btnEditNews_Click" />
            </p>
        </div>