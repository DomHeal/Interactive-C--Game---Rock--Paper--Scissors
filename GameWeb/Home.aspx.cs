using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        /*Shows current date in a label*/
        CurrentdateLbl.Text = "Current Date: " + DateTime.Now.ToString("dd/MM/yyyy");
    }
    protected void SubmitBtn_Click(object sender, EventArgs e)
    {
        /*Takes in Day and Month from user input and stores into a session for next webpage.*/
        string DateofBirth = DayTxtbox.Text + ("/") + MonthTxtbox.Text;
        Session["DoB"] = DateofBirth;
        Response.Redirect("~/Game.aspx");
    }
}