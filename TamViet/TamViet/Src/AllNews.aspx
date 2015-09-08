<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_FE.Master" AutoEventWireup="true" CodeBehind="AllNews.aspx.cs" Inherits="TamViet.Src.AllNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-support-online">
        <div class="menu-title">
            <span>Tin tức</span>
        </div>
        <div class="about-us">
            <div style="float: left; width: 40%;">
                <img src="/Images/medical_group.jpg" style="width: 100%; height: 190px;" />
            </div>
            <div style="float: left; width: 50%;">
                <p><b>Giới thiệu về chúng tôi</b></p>
                <div>
                    <asp:Literal runat="server" ID="litAboutUs"></asp:Literal>
                </div>
                <p><span class="hyperlink" style="float: right; margin-right: 10px; margin-left: 20px;">Xem chi tiết</span></p>
            </div>
        </div>
        <div class="about-us">
            <div style="float: left; width: 40%;">
                <img src="/Images/medical_group.jpg" style="width: 100%; height: 190px;" />
            </div>
            <div style="float: left; width: 50%;">
                <p><b>Giới thiệu về chúng tôi</b></p>
                <div>
                    <asp:Literal runat="server" ID="Literal1"></asp:Literal>
                </div>
                <p><span class="hyperlink" style="float: right; margin-right: 10px; margin-left: 20px;">Xem chi tiết</span></p>
            </div>
        </div>
        <div class="about-us">
            <div style="float: left; width: 40%;">
                <img src="/Images/medical_group.jpg" style="width: 100%; height: 190px;" />
            </div>
            <div style="float: left; width: 50%;">
                <p><b>Giới thiệu về chúng tôi</b></p>
                <div>
                    <asp:Literal runat="server" ID="Literal2"></asp:Literal>
                </div>
                <p><span class="hyperlink" style="float: right; margin-right: 10px; margin-left: 20px;">Xem chi tiết</span></p>
            </div>
        </div>
        <div class="about-us">
            <div style="float: left; width: 40%;">
                <img src="/Images/medical_group.jpg" style="width: 100%; height: 190px;" />
            </div>
            <div style="float: left; width: 50%;">
                <p><b>Giới thiệu về chúng tôi</b></p>
                <div>
                    <asp:Literal runat="server" ID="Literal3"></asp:Literal>
                </div>
                <p><span class="hyperlink" style="float: right; margin-right: 10px; margin-left: 20px;">Xem chi tiết</span></p>
            </div>
        </div>
        <div class="about-us">
            <div style="float: left; width: 40%;">
                <img src="/Images/medical_group.jpg" style="width: 100%; height: 190px;" />
            </div>
            <div style="float: left; width: 50%;">
                <p><b>Giới thiệu về chúng tôi</b></p>
                <div>
                    <asp:Literal runat="server" ID="Literal4"></asp:Literal>
                </div>
                <p><span class="hyperlink" style="float: right; margin-right: 10px; margin-left: 20px;">Xem chi tiết</span></p>
            </div>
        </div>
        <ul class="paging">
            <li><a href="#" class="active">1</a></li>
            <li><a href="#">1</a></li>
            <li><a href="#">1</a></li>
            <li><a href="#">1</a></li>
            <li><a href="#">1</a></li>
        </ul>
    </div>
</asp:Content>
