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
using System.Collections.Generic;
using System.Text;


namespace NopSolutions.NopCommerce.BusinessLogic.Promo.Discounts
{
    /// <summary>
    /// Represents a discount collection
    /// </summary>
    public partial class DiscountCollection : BaseEntityCollection<Discount>
    {
        /// <summary>
        /// Determines whether the collection contains the specified discount.
        /// </summary>
        /// <param name="DiscountName">Discount name</param>
        /// <returns>true if the collection contains a discount with the specified name; otherwise, false.</returns>
        public bool ContainsDiscount(string DiscountName)
        {
            bool result = false;
            foreach (Discount _discount in this)
                if (_discount.Name == DiscountName)
                {
                    result = true;
                    break;
                }

            return result;
        }
    }
}
