﻿<%@ Control Language="C#" AutoEventWireup="true" Inherits="NopSolutions.NopCommerce.Web.Modules.NewsListSkinControl"
    CodeBehind="NewsListSkin.ascx.cs" %>
<div id="shoppingcart">
    <div class="productname">
        <table style="width: 100%;">
            <tr>
                <td style="text-align: left; vertical-align: middle;">
                    <asp:Label ID="lblTitle" runat="server"></asp:Label>
                </td>
                <td style="text-align: right; vertical-align: middle;">
                    <a href="<%= GetNewsRSSUrl()%>">
                        <asp:Image ID="imgRSS" runat="server" ImageUrl="~/images/icon_rss.gif" AlternateText="RSS" /></a>
                </td>
            </tr>
        </table>
    </div>
    <div class="clear">
    </div>
    <div style="text-align:left">       
        <asp:DataGrid ID="gridtest" runat="server" AllowPaging="true" 
            AutoGenerateColumns="false"  GridLines="None" 
            onpageindexchanged="gridtest_PageIndexChanged" PageSize="5" ShowHeader="false" >
            <PagerStyle CssClass="phantrang" HorizontalAlign="Center" Mode="NumericPages" 
                NextPageText="Next" PrevPageText="Previous" VerticalAlign="Middle" />
            <Columns>
                <asp:TemplateColumn>                    
                    <ItemTemplate>
                        <div id="phongsu">
                            <div id="tenphongsu">
                                <a class="tieudephongsu" href="<%# SEOHelper.GetNewsURL(int.Parse(Eval("ForumTopicID").ToString())) %>"
                                    title="<%#Server.HtmlEncode(Eval("Subject").ToString())%>">
                                    <%#Server.HtmlEncode(Eval("Subject").ToString())%></a> <span style="float: right">
                                        <%#DateTimeHelper.ConvertToUserTime((DateTime)Eval("CreatedOn")).ToString("d")%>
                                    </span>
                            </div>
                            <div id="phongsu_hinh">
                                <asp:HyperLink ID="defaultImage" runat="server" ImageUrl='<%# GetPictureURL(Convert.ToInt32(Eval("PictureID"))) %>'
                                    NavigateUrl='<%# SEOHelper.GetNewsURL(int.Parse(Eval("ForumTopicID").ToString())) %>'
                                    ToolTip='<%#Eval("Subject")%>' />
                            </div>
                            <div id="phongsu_noidung">
                                <p>
                                    <%#Eval("ShortContent")%></p>
                                <a class="chitiet" href="<%# SEOHelper.GetNewsURL(int.Parse(Eval("ForumTopicID").ToString())) %>"
                                    title="<%#GetLocaleResourceString("News.MoreInfo") + " " + Server.HtmlEncode(Eval("Subject").ToString())%>">
                                    <%=GetLocaleResourceString("News.MoreInfo")%></a>
                            </div>
                        </div>
                    </ItemTemplate>                                    
                </asp:TemplateColumn>                                
            </Columns>
        </asp:DataGrid>
    </div>
</div>
