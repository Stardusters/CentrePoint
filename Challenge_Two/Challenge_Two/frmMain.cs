using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Challenge_Two
{
    public partial class frmMain : RadForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.tbxStringOne.Text) || string.IsNullOrWhiteSpace(this.tbxStringTwo.Text))
            {
                this.lblResult.ForeColor = Color.Maroon;
                this.lblResult.Text = "Error: Each of two strings to be compared must not be empty";
                return;
            }

            this.lblResult.ForeColor = Color.Black;
            string strOne = this.tbxStringOne.Text.Trim().ToLower();
            string strTwo = this.tbxStringTwo.Text.Trim().ToLower();

            if(strOne.Length != strTwo.Length)
            {
                this.lblResult.Text = "False, they are not anagrams";
                return;
            }

            strOne = string.Concat(strOne.OrderBy(x => x));
            strTwo = string.Concat(strTwo.OrderBy(y => y));

            if(strOne == strTwo)
            {
                this.lblResult.Text = "True, they are anagrams";
            }
            else
            {
                this.lblResult.Text = "False, they are not anagrams";
            }
        }
    }
}
