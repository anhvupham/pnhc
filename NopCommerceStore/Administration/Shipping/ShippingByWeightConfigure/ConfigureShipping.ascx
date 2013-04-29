<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="NopSolutions.NopCommerce.Web.Administration.Shipping.ShippingByWeightConfigure.ConfigureShipping" Codebehind="ConfigureShipping.ascx.cs" %>
<%@ Register TagPrefix="nopCommerce" TagName="DecimalTextBox" Src="../../Modules/DecimalTextBox.ascx" %>
<table class="adminContent">
    <tr>
        <td colspan="2" width="100%">
            <hr />
        </td>
    </tr>
    <tr>
        <td colspan="2" width="100%">
            <asp:GridView ID="gvShippingByWeights" runat="server" AutoGenerateColumns="false"
                DataKeyNames="ShippingByWeightID" OnRowDeleting="gvShippingByWeights_RowDeleting"
                OnRowDataBound="gvShippingByWeights_RowDataBound" OnRowCommand="gvShippingByWeights_RowCommand"
                Width="100%">
                <Columns>
                    <asp:TemplateField HeaderText="Shipping method" ItemStyle-Width="13%">
                        <ItemTemplate>
                            <asp:DropDownList ID="ddlShippingMethod" CssClass="adminInput" runat="server">
                            </asp:DropDownList>
                            <asp:HiddenField ID="hfShippingByWeightID" runat="server" Value='<%# Eval("ShippingByWeightID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="From" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="12%"
                        ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <nopCommerce:DecimalTextBox runat="server" CssClass="adminInput" Width="50px" Value='<%# Eval("From") %>'
                                ID="txtFrom" RequiredErrorMessage="From is required" MinimumValue="0" MaximumValue="999999"
                                ValidationGroup="UpdateShippingByWeight" RangeErrorMessage="The value must be from 0 to 999999">
                            </nopCommerce:DecimalTextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="To" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="10%"
                        ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <nopCommerce:DecimalTextBox runat="server" CssClass="adminInput" Width="50px" Value='<%# Eval("To") %>'
                                ID="txtTo" RequiredErrorMessage="To is required" MinimumValue="0" MaximumValue="999999"
                                ValidationGroup="UpdateShippingByWeight" RangeErrorMessage="The value must be from 0 to 999999">
                            </nopCommerce:DecimalTextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Use Percentage" HeaderStyle-HorizontalAlign="Center"
                        ItemStyle-Width="15%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="cbUsePercentage" Checked='<%# Eval("UsePercentage") %>'>
                            </asp:CheckBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Charge percentage" HeaderStyle-HorizontalAlign="Center"
                        ItemStyle-Width="15%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <nopCommerce:DecimalTextBox runat="server" CssClass="adminInput" Width="50px" Value='<%# Eval("ShippingChargePercentage") %>'
                                ID="txtShippingChargePercentage" RequiredErrorMessage="Charge percentage is required"
                                MinimumValue="0" MaximumValue="100" ValidationGroup="UpdateShippingByWeight"
                                RangeErrorMessage="The value must be from 0 to 100"></nopCommerce:DecimalTextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Charge amount" HeaderStyle-HorizontalAlign="Center"
                        ItemStyle-Width="15%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <nopCommerce:DecimalTextBox runat="server" CssClass="adminInput" Width="50px" Value='<%# Eval("ShippingChargeAmount") %>'
                                ID="txtShippingChargeAmount" RequiredErrorMessage="Charge amount is required"
                                MinimumValue="0" MaximumValue="999999" ValidationGroup="UpdateShippingByWeight"
                                RangeErrorMessage="The value must be from 0 to 999999"></nopCommerce:DecimalTextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Update" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="10%"
                        ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:Button ID="btnUpdate" runat="server" CssClass="adminButton"  Text="Update" ValidationGroup="UpdateShippingByWeight"
                                CommandName="UpdateShippingByWeight" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="10%"
                        ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" CssClass="adminButton"  Text="Delete" CausesValidation="false"
                                CommandName="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="2" width="100%">
            <hr />
        </td>
    </tr>
    <tr>
        <td colspan="2" width="100%">
            <br />
            Adding new values:
        </td>
    </tr>
    <tr>
        <td class="adminTitle">
            Select shipping method:
        </td>
        <td class="adminData">
            <asp:DropDownList ID="ddlShippingMethod" runat="server" CssClass="adminInput">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="adminTitle">
            Order weight from [<%=MeasureManager.BaseWeightIn.Name%>]:
        </td>
        <td class="adminData">
            <nopCommerce:DecimalTextBox runat="server" ID="txtFrom" Value="0" RequiredErrorMessage="From is required"
                MinimumValue="0" MaximumValue="999999" ValidationGroup="AddShippingByWeight"
                RangeErrorMessage="The value must be from 0 to 999999" CssClass="adminInput">
            </nopCommerce:DecimalTextBox>
        </td>
    </tr>
    <tr>
        <td class="adminTitle">
            Order weight to [<%=MeasureManager.BaseWeightIn.Name%>]:
        </td>
        <td class="adminData">
            <nopCommerce:DecimalTextBox runat="server" ID="txtTo" Value="0" RequiredErrorMessage="To is required"
                MinimumValue="0" MaximumValue="999999" ValidationGroup="AddShippingByWeight"
                RangeErrorMessage="The value must be from 0 to 999999" CssClass="adminInput">
            </nopCommerce:DecimalTextBox>
        </td>
    </tr>
    <tr>
        <td class="adminTitle">
            Use percentage:
        </td>
        <td class="adminData">
            <asp:CheckBox runat="server" ID="cbUsePercentage"></asp:CheckBox>
        </td>
    </tr>
    <tr>
        <td class="adminTitle">
            Charge percentage (of subtotal):
        </td>
        <td class="adminData">
            <nopCommerce:DecimalTextBox runat="server" ID="txtShippingChargePercentage" Value="0"
                RequiredErrorMessage="Charge percentage is required" MinimumValue="0" MaximumValue="100"
                ValidationGroup="AddShippingByWeight" RangeErrorMessage="The value must be from 0 to 100"
                CssClass="adminInput"></nopCommerce:DecimalTextBox>
        </td>
    </tr>
    <tr>
        <td class="adminTitle">
            Charge amount [<%=CurrencyManager.PrimaryStoreCurrency.CurrencyCode%>] per <%=MeasureManager.BaseWeightIn.Name%>:
        </td>
        <td class="adminData">
            <nopCommerce:DecimalTextBox runat="server" ID="txtShippingChargeAmount" Value="0"
                RequiredErrorMessage="Charge amount is required" MinimumValue="0" MaximumValue="999999"
                ValidationGroup="AddShippingByWeight" RangeErrorMessage="The value must be from 0 to 999999"
                CssClass="adminInput"></nopCommerce:DecimalTextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" align="left">
            <asp:Button runat="server" ID="btnAdd" Text="Add new" CssClass="adminButton" ValidationGroup="AddShippingByWeight"
                OnClick="btnAdd_Click"></asp:Button>
        </td>
    </tr>
    <tr>
        <td colspan="2" width="100%">
            <hr />
        </td>
    </tr>
</table>
