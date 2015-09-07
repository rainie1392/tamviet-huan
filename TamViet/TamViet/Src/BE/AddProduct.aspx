<%@ Page Title="" Language="C#" MasterPageFile="~/Src/BE/_Admin.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="TamViet.Src.BE.AddProduct" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <div class="contenttitle2">
            <h3>Add New Product</h3>
        </div>
        <div class="stdform stdform2">
            <p>
                <label>Tên sản phẩm</label>
                <span class="field"><asp:TextBox runat="server" ID="txtName" CssClass="longinput"></asp:TextBox></span>
            </p>
                        
            <p>
                <label>Danh mục</label>
                <span class="field"><asp:DropDownList runat="server" ID="ddlCategory"></asp:DropDownList></span>
            </p>
                        
            <p>
                <label>Hãng sản xuất</label>
                <span class="field"><asp:TextBox runat="server" ID="txtManufacturer" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Năm sản xuất</label>
                <span class="field"><asp:TextBox runat="server" ID="txtYear" CssClass="longinput"></asp:TextBox></span>
            </p>
                        
            <p>
                <label>Quốc gia</label>
                <span class="field"><asp:TextBox runat="server" ID="txtCountry"></asp:TextBox></span>
            </p>
                        
            <p>
                <label>Đạt tiêu chuẩn chất lượng</label>
                <span class="field"><asp:TextBox runat="server" ID="txtCriterion" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Nguồn cấp</label>
                <span class="field"><asp:TextBox runat="server" ID="txtPower" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Nhiệt độ làm việc</label>
                <span class="field"><asp:TextBox runat="server" ID="txtTemperature" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Độ ẩm làm việc</label>
                <span class="field"><asp:TextBox runat="server" ID="txtHumidity" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Giá thành</label>
                <span class="field"><asp:TextBox runat="server" ID="txtPrice" CssClass="longinput"></asp:TextBox></span>
            </p>
            <p>
                <label>Hình ảnh sản phẩm</label>
                <span class="field"><asp:FileUpload runat="server" ID="fileUpload" /></span>
            </p>
            <p>
                <label>Active</label>
                <span class="field"><asp:CheckBox runat="server" ID="chkActive" /></span>
            </p>
            <p>
                <label>Thông tin chi tiết</label>
                <span class="field"><ckeditor:ckeditorcontrol id="txtContent" basepath="/js/plugins/ckeditor/" runat="server" height="200"></ckeditor:ckeditorcontrol></span>
            </p>
                        
            <p class="stdformbutton">
                <asp:Button runat="server" ID="btnAdd" CssClass="submit radius2" OnClick="btnAdd_Click" Text="Thêm mới" />
            </p>
        </div>
    </div>
</asp:Content>
