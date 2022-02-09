using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Object_Creation
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calcvolume_Click(object sender, EventArgs e)
        {
            Class1 f;
        
            Double rad1, pie1, volume1;
            rad1 = Double.Parse(tb_radius.Text);
            pie1 = 3.14;
            f = new Class1(rad1, pie1);
            f.calcVolume();
            volume1 = 1.33 * rad1 * rad1 * rad1 * pie1;
            tb_volume.Text = volume1.ToString();

        }

        protected void calcSurface_Click(object sender, EventArgs e)
        {
            Class1 f;
            Double rad1, pie1, surface1;
            pie1 = 3.14;
            rad1 = Double.Parse(tb_rad2.Text);
            f = new Class1(rad1, pie1);
            f.calcSurface();
            surface1 = 4 * pie1 * rad1 * rad1;
            tb_surface.Text = surface1.ToString();

        }
    }
}