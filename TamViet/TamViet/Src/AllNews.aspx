<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_FE.Master" AutoEventWireup="true" CodeBehind="AllNews.aspx.cs" Inherits="TamViet.Src.AllNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            function getParameterByName(name) {
                name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
                var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
                    results = regex.exec(location.search);
                return results == null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
            }
            $('.paging li a').click(function (e) {
                e.preventDefault();
                var m = getParameterByName('category');
                var url = window.location.href;
                if (m.length > 0) {
                    var ref = $(this).attr('href').replace('?', ' ').trim();
                    url = url + '&' + ref;
                }
                else {
                    var ref = $(this).attr('href');
                    url = url + ref;
                }
                window.location.href = url;
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-support-online">
        <div class="menu-title">
            <span>Tin tức</span>
        </div>
        <asp:Literal runat="server" ID="ltNews"></asp:Literal>
        <ul class="paging">
            <asp:Literal runat="server" ID="ltPagging"></asp:Literal>        
        </ul>
    </div>
</asp:Content>
