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




namespace NopSolutions.NopCommerce.DataAccess.Game
{

    public partial class DBCustomerResultDetail : BaseDBEntity
    {
        #region Ctor
     
        public DBCustomerResultDetail()
        {
        }
        #endregion

        #region Properties

        public int ID { get; set; }

        public int CustomerResultID { get; set; }

        public int QuestionID { get; set; }

        public int AnswerID { get; set; }

        public bool IsCorrect { get; set; }
        
        #endregion 

        
    }

}
