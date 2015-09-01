<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_FE.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TamVietFE.Src.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>This is HomePage</h2>
    <%--<div class="FeaturedProducts DefaultModule CustomProduct-959928 HomeFeaturedProducts">
    <div class="defaultTitle TitleContent">
        <h1>Sản phẩm</h1>
    </div>
    <div class="defaultContent BlockContent">
        <div class="view-box clearfix">
            <div class="views fl">
                <ul>
                    <li><a title="Hiển thị dạng bảng" class="view-table"></a></li>
                    <li><a title="Hiển thị dạng danh sách" class="view-list"></a></li>
                </ul>
            </div>
            <div class="limit">
                <p>
                    Sản phẩm/ trang</p>
                <select id="lblimit" name="lblimit" class="nb_item" onchange="window.location.href = this.options[this.selectedIndex].value">
                        <option value="?limit=10">10</option>
                        <option selected="selected" value="?limit=12">12</option>
                        <option value="?limit=20">20</option>
                        <option value="?limit=50">50</option>
                        <option value="?limit=100">100</option>
                        <option value="?limit=250">250</option>
                        <option value="?limit=500">500</option>
                </select>
            </div>
            <div class="fr SortBox">
                Sắp xếp theo:
                <select class="selectProductSort" id="lbsort" onchange="window.location.href = this.options[this.selectedIndex].value">
                        <option selected="selected" value="?sort=index&amp;order=asc">Mặc định</option>
                        <option value="?sort=price&amp;order=asc">Giá tăng dần</option>
                        <option value="?sort=price&amp;order=desc">Giá giảm dần</option>
                        <option value="?sort=name&amp;order=asc">Tên sản phẩm: A to Z</option>
                        <option value="?sort=name&amp;order=desc">Tên sản phẩm: Z to A</option>
                </select>
            </div>
        </div>
        <ul class="ProductList First">
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/ford-festa.html">
                            <img alt="Ford Festa" title="Ford Festa" src="abc/ford%2520fiesta%252038364-2.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/ford-festa.html">
                                Ford Festa</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4500,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/ford-ranger.html">
                            <img alt="Ford Ranger" title="Ford Ranger" src="abc/ford%2520ranger%25202767-2.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/ford-ranger.html">
                                Ford Ranger</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4501,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/toyota-camry.html">
                            <img alt="Toyota Camry" title="Toyota Camry" src="abc/resized_IMG_4876.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/toyota-camry.html">
                                Toyota Camry</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4492,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/toyota-yaris.html">
                            <img alt="Toyota Yaris" title="Toyota Yaris" src="abc/toyota%2520YARIS%252007190-2.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/toyota-yaris.html">
                                Toyota Yaris</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4493,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/mini-cooper.html">
                            <img alt="Mini Cooper" title="Mini Cooper" src="abc/MINI%2520COOPER%252084333-2.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/mini-cooper.html">
                                Mini Cooper</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4504,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/volkwagen.html">
                            <img alt="Volkwagen" title="Volkwagen" src="abc/wolkwagen%252062367-1.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/volkwagen.html">
                                Volkwagen</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4505,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/bmw-328i.html">
                            <img alt="BMW 328I" title="BMW 328I" src="abc/BMW%252044740-3.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/bmw-328i.html">
                                BMW 328I</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4506,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/chevrolet-captive.html">
                            <img alt="Chevrolet Captive" title="Chevrolet Captive" src="abc/CHEVROLET%2520CAPTIVA%25206874-1.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/chevrolet-captive.html">
                                Chevrolet Captive</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4507,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/fortuner-27v-2011.html">
                            <img alt="Fortuner 2.7V 2011" title="Fortuner 2.7V 2011" src="abc/fortuner%252004182-3.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/fortuner-27v-2011.html">
                                Fortuner 2.7V 2011</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4494,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/fortuner-2012-bac.html">
                            <img alt="Fortuner 2012 Bạc" title="Fortuner 2012 Bạc" src="abc/fortuner%252037107-4.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/fortuner-2012-bac.html">
                                Fortuner 2012 Bạc</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4495,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/fortuner-27v-2010.html">
                            <img alt="Fortuner 2.7V 2010" title="Fortuner 2.7V 2010" src="abc/fortuner%252072095-1.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/fortuner-27v-2010.html">
                                Fortuner 2.7V 2010</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4496,1)"><span>Mua hàng</span></a></div>
                </li>
                <li class="Odd">
                    <div class="ProductImage ProductImageTooltip">
                        <a href="http://runecom13.webonline.vn/san-pham/grandis-51ld.html">
                            <img alt="Grandis 51LD" title="Grandis 51LD" src="abc/grandis%252051LD%25204517%2520UP-1.JPG">
                        </a>
                    </div>
                    <span class="NewFlag"></span>
                    <div class="ProductDetails">
                        <h2>
                            <a href="http://runecom13.webonline.vn/san-pham/grandis-51ld.html">
                                Grandis 51LD</a></h2>
                    </div>
                    <div class="ProductPrice">
                            <div class="special-price">
                                <span class="price-label"></span><span class="price"><em>0
                                    ₫</em> </span>
                            </div>
                    </div>
                    
                        <div class="ProductActionAdd">
                            <a href="javascript:void(0)" onclick="AddToCard(4502,1)"><span>Mua hàng</span></a></div>
                </li>
            <div class="clear">
            </div>
        </ul>
        <div class="clear">
        </div>
            <div class="PageNavigation" style="padding-bottom: 10px; padding-top: 10px;" align="center">
                    <a class="active" href="http://runecom13.webonline.vn/?page=1" style="background-color: gray; color: white;">
                        <strong>1</strong></a>
                    <a href="http://runecom13.webonline.vn/?page=2">2</a>
                    <a href="http://runecom13.webonline.vn/?page=3">3</a>
                    <a href="http://runecom13.webonline.vn/?page=4">4</a>
            </div>
    </div>
    <div class="defaultFooter FooterContent">
        <div>
        </div>
    </div>
    <div class="Clear">
    </div>
</div>--%>
</asp:Content>
