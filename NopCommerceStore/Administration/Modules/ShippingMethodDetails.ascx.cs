//------------------------------------------------------------------------------
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
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using NopSolutions.NopCommerce.BusinessLogic.Shipping;
using NopSolutions.NopCommerce.Common.Utils;

namespace NopSolutions.NopCommerce.Web.Administration.Modules
{
    public partial class ShippingMethodDetailsControl : BaseNopAdministrationUserControl
    {
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    ShippingMethod shippingMethod = ctrlShippingMethodInfo.SaveInfo();
                    Response.Redirect("ShippingMethodDetails.aspx?ShippingMethodID=" + shippingMethod.ShippingMethodID.ToString());
                }
                catch (Exception exc)
                {
                    ProcessException(exc);
                }
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShippingMethodManager.DeleteShippingMethod(this.ShippingMethodID);
                Response.Redirect("ShippingMethods.aspx");
            }
            catch (Exception exc)
            {
                ProcessException(exc);
            }
        }

        public int ShippingMethodID
        {
            get
            {
                return CommonHelper.QueryStringInt("ShippingMethodID");
            }
        }
    }
}