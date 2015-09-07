<%@ Page Title="" Language="C#" MasterPageFile="~/Src/BE/_Admin.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="TamViet.Src.BE.EditProduct" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/lightbox.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <asp:HiddenField runat="server" ID="hidValue" />
        <div class="contenttitle2">
            <h3>Edit Product</h3>
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
                            <span class="field">
                                <%--<a href="images/image-1.jpg" data-lightbox="image-1" data-title="My caption">Image #1</a>--%>
                                <asp:HyperLink runat="server" ID="lnkImages"><asp:Image runat="server" ID="imgProduct" Width="200" /></asp:HyperLink>
                            </span>
                            <a href="#" class="preview"></a>
                        </p>
                        <p>
                        	<label>Thay đổi hình ảnh</label>
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
                            <asp:Button runat="server" ID="btnUpdate" CssClass="submit radius2" OnClick="btnUpdate_Click" Text="Cập nhật" />
                        </p>
                    </div>
    </div>
</asp:Content>
