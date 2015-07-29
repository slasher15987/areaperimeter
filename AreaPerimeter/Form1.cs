using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal length = Convert.ToDecimal(txtLength.Text); //set length to user submitted number
            decimal width = Convert.ToDecimal(txtWidth.Text);   //set width to user submitted number
            decimal area = (width * length);                    //calculate area
            decimal perimeter = ((2 * width) + (2 * length));   //calculate perimeter

            txtArea.Text = area.ToString(""); //set the area textbox to the solution from the area calculation
            txtPerimeter.Text = perimeter.ToString(""); //set the perimeter textbox to the solution from the perimeter calculation
        }
    }
}
