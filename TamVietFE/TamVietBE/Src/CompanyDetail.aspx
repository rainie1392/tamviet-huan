<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_Admin.Master" AutoEventWireup="true" CodeBehind="CompanyDetail.aspx.cs" Inherits="TamVietBE.Src.CompanyDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <asp:HiddenField runat="server" ID="hidVal" />
        <div class="contenttitle2">
            <h3>Thông tin công ty</h3>
        </div>
        <div class="stdform stdform2">
            <p>
                <label>Địa chỉ</label>
                <span class="field"><asp:TextBox runat="server" ID="txtAddress" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Số điện thoại</label>
                <span class="field"><asp:TextBox runat="server" ID="txtPhone" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Hotline</label>
                <span class="field"><asp:TextBox runat="server" ID="txtHotline" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Email</label>
                <span class="field"><asp:TextBox runat="server" ID="txtEmail" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Website</label>
                <span class="field"><asp:TextBox runat="server" ID="txtWebsite" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Tên công ty</label>
                <span class="field"><asp:TextBox runat="server" ID="txtCompanyName" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Mã số thuế</label>
                <span class="field"><asp:TextBox runat="server" ID="txtTaxCode" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p class="stdformbutton">
                <asp:Button runat="server" ID="btnUpdate" CssClass="submit radius2" OnClick="btnUpdate_Click" Text="Cập nhật" />
            </p>
        </div>
    </div>
</asp:Content>
