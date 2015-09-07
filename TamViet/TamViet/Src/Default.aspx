﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_FE.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TamViet.Src.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .about-us {
            width : 100%;
            height : 215px;
            border-bottom:1px dotted #ddd;
            line-height:25px;
            }
        .product {
            border-bottom : 3px solid #2C81D9;
            color : #2C81D9;
            position : relative;
            padding-top:20px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="about-us">
        <div style="float:left;width:50%;">
            <img src="/Images/medical_group.jpg" style="width:100%;height:210px;"/>
        </div>
        <div style="float:left;width:50%;">
            <p><b>Giới thiệu về chúng tôi</b></p>
            <div>
                <asp:Literal runat="server" ID="litAboutUs"></asp:Literal>
            </div>
            <p><span class="hyperlink" style="float:right;margin-right:10px;margin-left:20px;">Xem chi tiết</span></p>
        </div>
    </div>
    <div class="product">
        <div style="position:absolute; height:20px; background-color:#f1f1f1;margin-left:20px;width:110px; text-align:center; margin-top:-17px;font-size:20px;font-weight:bold;">
            Sản phẩm
        </div>
    </div>
    <div class="detail">
            <ul style="width:100%">
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>
                <li>
                    <img src="/Images/product/CA600.jpg" style="width:99%;height:130px;"/>
                    <div class="see-detail"><b>Xem chi tiết</b></div>
                    <p style="color:#CCA300;font-size:14px; font-weight:bold;text-align:center;">9.800.000 VND</p>
                    <p style="font-size:14px; font-weight:bold; text-align:center;width:90%;">CA600 Series</p>
                </li>

            </ul>
        </div>
</asp:Content>