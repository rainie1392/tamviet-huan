<%@ Page Title="" Language="C#" MasterPageFile="~/Src/_Admin.Master" AutoEventWireup="true" CodeBehind="CategoryManager.aspx.cs" Inherits="TamVietBE.Src.CategoryManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader notab">
            <h2 class="pagetitle">Quản lý thông tin về sản phẩm</h2>
            <span class="pagedesc">This is a sample description of a page</span>
            
        </div><!--pageheader-->
    <div id="contentwrapper" class="contentwrapper lineheight21">
        <div class="contenttitle2">
            <h3>Category Manager</h3>
        </div>
        <table cellpadding="0" cellspacing="0" border="0" class="stdtable">
                    <colgroup>
                        <col class="con0" />
                        <col class="con1" />
                        <col class="con0" />
                        <col class="con1" />
                        <col class="con0" />
                    </colgroup>
                    <thead>
                        <tr>
                            <th class="head0"></th>
                            <th class="head1">Name</th>
                            <th class="head0">SubCategory</th>
                            <th class="head1">ParentId</th>
                            <th class="head0">Amendment</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th class="head0"></th>
                            <th class="head1"><asp:TextBox runat="server" ID="txtNewCatName"></asp:TextBox></th>
                            <th class="head0"><asp:CheckBox runat="server" ID="chkIsSub" /></th>
                            <th class="head1"><asp:DropDownList Visible="false" runat="server" ID="ddlListCat"></asp:DropDownList></th>
                            <th class="head0"><asp:ImageButton ID="btnAddNew" runat="server" ImageUrl="/images/Event/add.png" /></th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <asp:ListView runat="server" ID="lvCategory" OnItemDataBound="lvCategory_ItemDataBound" OnItemCommand="lvCategory_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td></td>
                                    <td>Internet Explorer 4.0</td>
                                    <td>Win 95+</td>
                                    <td class="center">4</td>
                                    <td class="center"><asp:ImageButton ID="btnUpdate" runat="server"
                        CommandName="cmdUpdate" CommandArgument='<%#Eval("Id") %>' ImageUrl="~/images/Event/edit.png" />
                                        <asp:ImageButton ID="btnDelete" runat="server"
                        CommandName="cmdDelete" CommandArgument='<%#Eval("Id") %>' ImageUrl="~/images/Event/delete.png" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                        
                        <tr>
                            <td>Trident</td>
                            <td>Internet Explorer 5.0</td>
                            <td>Win 95+</td>
                            <td class="center">5</td>
                            <td class="center">C</td>
                        </tr>
                        <tr>
                            <td>Trident</td>
                            <td>Internet  Explorer 5.5</td>
                            <td>Win 95+</td>
                            <td class="center">5.5</td>
                            <td class="center">A</td>
                        </tr>
                        <tr>
                            <td>Trident</td>
                            <td>Internet Explorer 6</td>
                            <td>Win 98+</td>
                            <td class="center">6</td>
                            <td class="center">A</td>
                        </tr>
                        <tr>
                            <td>Trident</td>
                            <td>Internet Explorer 7</td>
                            <td>Win XP SP2+</td>
                            <td class="center">7</td>
                            <td class="center">A</td>
                        </tr>
                    </tbody>
                </table>
    </div>
</asp:Content>
