using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class confirmFrame : Form
    {

        private string _scope;

        public string Scope
        {
            get { return _scope; }
            set { _scope = value; }
        }

        public confirmFrame()
        {
            InitializeComponent();
        }

        private void confirmFrame_Load(object sender, EventArgs e)
        {
            this.totalTxt.Text = this._scope;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this._scope = this.totalTxt.Text;
            this.Close();
        }





    }
}
