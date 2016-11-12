using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RandomNumbers
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int iniNumber = 10000;
            if (!IsPostBack)
            {
                txtInputNumber.Text = iniNumber.ToString();
            }
            RandomNumber numbers = new RandomNumber();

            int qty = Int32.Parse(txtInputNumber.Text);
            List<int> result = numbers.GenerateRandom(qty);
            rNumbers.DataSource = result;
            rNumbers.DataBind();
        }
    }
}