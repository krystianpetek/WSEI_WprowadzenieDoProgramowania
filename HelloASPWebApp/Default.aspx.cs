using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASPWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            LabelKom1.Text = ($"Witaj {TextBoxImie.Text} {TextBoxNazwisko.Text}");
            int wiek = Convert.ToInt32(TextBoxWiek.Text);
            if(wiek < 0)
            {
                LabelKom2.Text = "Błędnie wprowadzone dane";
            }
            else if (wiek < 67)
            {
                int obliczWiek = 67 - wiek;
                LabelKom2.Text = ($"w wieku {wiek} zostało Ci {obliczWiek} lat do emerytury");
            }
            else
            {
                LabelKom2.Text = "Jesteś na emeryturze";
            }
        }
    }
}