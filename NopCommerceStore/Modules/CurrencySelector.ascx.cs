﻿//------------------------------------------------------------------------------
// The contents of this file are subject to the nopCommerce Public License Version 1.0 ("License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at  http://www.nopCommerce.com/License.aspx. 
// 
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. 
// See the License for the specific language governing rights and limitations under the License.
// 
// The Original Code is nopCommerce.
// The Initial Developer of the Original Code is NopSolutions.
// All Rights Reserved.
// 
// Contributor(s): _______. 
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using NopSolutions.NopCommerce.BusinessLogic;
using NopSolutions.NopCommerce.BusinessLogic.Directory;
using NopSolutions.NopCommerce.Common.Utils;

namespace NopSolutions.NopCommerce.Web.Modules
{
    public partial class CurrencySelectorControl : BaseNopUserControl
    {

        private void BindCurrencies()
        {
            CurrencyCollection currencies = CurrencyManager.GetAllCurrencies();
            if (currencies.Count > 1)
            {
                this.Visible = true;
                this.ddlCurrencies.Items.Clear();
                Currency customerCurrency = NopContext.Current.WorkingCurrency;
                foreach (Currency currency in currencies)
                {
                    ListItem item = new ListItem(currency.Name, currency.CurrencyID.ToString());
                    this.ddlCurrencies.Items.Add(item);
                }
                if (customerCurrency != null)
                    CommonHelper.SelectListItem(this.ddlCurrencies, customerCurrency.CurrencyID);
            }
            else
                this.Visible = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindCurrencies();
            }
        }

        protected void ddlCurrencies_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int currencyID = int.Parse(this.ddlCurrencies.SelectedItem.Value);
            Currency currency = CurrencyManager.GetCurrencyByID(currencyID);
            if (currency != null && currency.Published)
            {
                NopContext.Current.WorkingCurrency = currency;
                CommonHelper.ReloadCurrentPage();
            }
        }

    }
}
