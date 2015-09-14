<%@ Page Title="" Language="C#" MasterPageFile="~/Src/BE/_Admin.Master" AutoEventWireup="true" CodeBehind="ProductImages.aspx.cs" Inherits="TamViet.Src.BE.PageImages.ProductImages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/js/plugins/jquery-1.7.min.js"></script>
    <script>
        jQuery(document).ready(function () {
            jQuery('.image').click(function (e) {
                e.preventDefault();
                window.prompt("Địa chỉ của ảnh :", jQuery(this).find('.image-detail').attr('src'));
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <div class="contenttitle2">
            <h3>Hình ảnh sản phẩm</h3>
        </div>
        <br />
        

        Thêm ảnh mới : <asp:FileUpload runat="server" ID="fileUpload" />
        <br />
        <ul class="listfile">
        <asp:ListView runat="server" ID="litImages" OnItemDataBound="litImages_ItemDataBound" OnPagePropertiesChanging="litImages_PagePropertiesChanging">
            <ItemTemplate>
                <li>
                    <a class="image" href="#">
                        <span class="img"><asp:Image CssClass="image-detail" runat="server" ID="img" Width="130" Height="110" /></span>
                        <span class="filename"><b><asp:Literal runat="server" ID="litFileName"></asp:Literal></b></span></a>
                </li>
            </ItemTemplate>
        </asp:ListView>
            </ul>
        <br />
        <asp:DataPager ID="dtpgImages" runat="server" PagedControlID="litImages" PageSize="30">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
            <asp:NumericPagerField ButtonCount="10" ButtonType="Button" NextPageText="&gt;" NumericButtonCssClass="pager-grid" PreviousPageText="&lt;" />
            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
    </div>
</asp:Content>
