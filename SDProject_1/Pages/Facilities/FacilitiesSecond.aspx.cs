﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDProject_1.Pages
{
    public partial class FacilitiesSecond : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void buttonCreateFacility_Click(object sender, EventArgs e)
        {
            Response.Redirect("Facilities.aspx");
        }
    }
}