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


namespace NopSolutions.NopCommerce.DataAccess.Media
{
    /// <summary>
    /// Represents a download
    /// </summary>
    public partial class DBDownload : BaseDBEntity
    {
        #region Ctor
        /// <summary>
        /// Creates a new instance of the DBDownload class
        /// </summary>
        public DBDownload()
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the download identifier
        /// </summary>
        public int DownloadID { get; set; }

        /// <summary>
        /// Gets a sets a value indicating whether DownloadURL property should be used
        /// </summary>
        public bool UseDownloadURL { get; set; }

        /// <summary>
        /// Gets a sets a download URL
        /// </summary>
        public string DownloadURL { get; set; }

        /// <summary>
        /// Gets or sets the download binary
        /// </summary>
        public byte[] DownloadBinary { get; set; }

        /// <summary>
        /// The mime-type of the download
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the extension
        /// </summary>
        public string Extension { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the download is new
        /// </summary>
        public bool IsNew { get; set; }
        #endregion 
    }

}
