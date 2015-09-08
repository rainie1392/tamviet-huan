<%@ Page Title="" Language="C#" MasterPageFile="~/Src/BE/_Admin.Master" AutoEventWireup="true" CodeBehind="EditNews.aspx.cs" Inherits="TamViet.Src.BE.PageNews.EditNews" %>
<%@ Register Src="~/Src/BE/PageNews/usrNews.ascx" TagPrefix="uc1" TagName="usrNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <uc1:usrNews runat="server" id="usrNews" />
        </div>
</asp:Content>
