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



namespace NopSolutions.NopCommerce.BusinessLogic.Content.Polls
{
    /// <summary>
    /// Represents a poll answer
    /// </summary>
    public partial class PollAnswer : BaseEntity
    {
        #region Ctor
        /// <summary>
        /// Creates a new instance of the PollAnswer class
        /// </summary>
        public PollAnswer()
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the poll answer identifier
        /// </summary>
        public int PollAnswerID { get; set; }

        /// <summary>
        /// Gets or sets the poll identifier
        /// </summary>
        public int PollID { get; set; }

        /// <summary>
        /// Gets or sets the poll answer name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the current count
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        #endregion

        #region Custom Properties

        /// <summary>
        /// Gets the poll
        /// </summary>
        public Poll Poll
        {
            get
            {
                return PollManager.GetPollByID(PollID);
            }
        }

        #endregion
    }

}
