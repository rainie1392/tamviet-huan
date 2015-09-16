<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_FE.Master" AutoEventWireup="true" CodeBehind="NewsDetail.aspx.cs" Inherits="TamViet.Src.NewsDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="menu-title">
                <span><asp:Literal runat="server" ID="litTitle"></asp:Literal></span>
            </div>
        <div style="margin-left:15px;">
        <asp:Literal runat="server" ID="litContent"></asp:Literal>
            </div>
    </div>
</asp:Content>
