﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Phones : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //redirect back to main page 
        Response.Redirect("Default.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to main page 
        Response.Redirect("Default.aspx");
    }
}