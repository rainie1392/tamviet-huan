<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_FE.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="TamViet.Src.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
         <div class="menu-title">
                <span>Thông tin chi tiết</span>
            </div>
        <div class="about-us">
        <div style="float:left;width:40%;">
            <img src="/Images/product/CA600.jpg" style="width:100%;height:200px;"/>
        </div>
        <div style="float:left;width:50%;margin-left:35px;">
            <p style="font-size:16px;"><b>CA 600 Series</b></p>
            <p>Loại máy   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;  : Máy xét nghiệm sinh hóa</p>
            <p>Hãng sản xuất  &nbsp;&nbsp;     : Horiba Medical</p>
            <p>Xuất xứ    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;  : Nhật Bản</p>
            <p>Tiêu chuẩn &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;        : ISO 9001, ISO 13485, IEC</p>
            <p>Chất lượng  &nbsp; &nbsp; &nbsp; &nbsp;     : Brandnew</p>
            <p>Nguồn cấp   &nbsp; &nbsp; &nbsp;  &nbsp;&nbsp;   : 100-240V/50Hz - 60Hz - 800VA</p>
            <p>Nhiệt độ làm việc : 18 - 32 C</p>
        </div>
    </div>
        <br />
        <asp:Literal runat="server" ID="litProductDetail"></asp:Literal>
    </div>
</asp:Content>
