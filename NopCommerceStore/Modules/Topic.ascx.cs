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
using NopSolutions.NopCommerce.BusinessLogic.Configuration.Settings;
using NopSolutions.NopCommerce.BusinessLogic.Content.Topics;
using NopSolutions.NopCommerce.BusinessLogic.SEO;

namespace NopSolutions.NopCommerce.Web.Modules
{
    public partial class TopicControl : BaseNopUserControl
    {
        protected override void OnInit(EventArgs e)
        {
            BindData();
            base.OnInit(e);
        }

        private void BindData()
        {
            LocalizedTopic localizedTopic = TopicManager.GetLocalizedTopic(this.TopicName, NopContext.Current.WorkingLanguage.LanguageID);
            if (localizedTopic != null)
            {
                if (!string.IsNullOrEmpty(localizedTopic.Title))
                {
                    lTitle.Text = Server.HtmlEncode(localizedTopic.Title);
                    SEOHelper.RenderTitle(this.Page, localizedTopic.Title, true, true);
                    SEOHelper.RenderMetaTag(this.Page, "description", localizedTopic.Title, true);
                    SEOHelper.RenderMetaTag(this.Page, "keywords", localizedTopic.Title, true);
                }
                else
                {
                    lTitle.Visible = false;
                }
                if (!string.IsNullOrEmpty(localizedTopic.Body))
                {
                    lBody.Text = localizedTopic.Body;
                }
                else
                {
                    lBody.Visible = false;
                }
            }
            else
                this.Visible = false;
        }

        public string TopicName
        {
            get
            {
                object obj2 = this.ViewState["TopicName"];
                if (obj2 != null)
                    return (string)obj2;
                else
                    return string.Empty;
            }
            set
            {
                this.ViewState["TopicName"] = value;
            }
        }
    }
}
