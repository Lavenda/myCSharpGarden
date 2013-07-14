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
    public partial class mainFrom : Form
    {
        private int _scope = 999;

        public mainFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void showNumTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int bingoNum = random.Next(_scope);
            this.numLab.Text = this._formatNum(bingoNum);
        }

        private void uniBtn_Click(object sender, EventArgs e)
        {
            if (this.uniBtn.Text == "Start")
            {
                this.uniBtn.Text = "Stop";
                this.showNumTimer.Start();
          
            }
            else
            {
                this.uniBtn.Text = "Start";
                this.showNumTimer.Stop();
            }
        }

        private String _formatNum(int num)
        {
            return num.ToString("000");

        }

        private void authorLab_DoubleClick(object sender, EventArgs e)
        {
            confirmFrame cf = new confirmFrame();
            cf.Scope = this._scope.ToString();
            DialogResult result = cf.ShowDialog();
            this._scope = Convert.ToInt16(cf.Scope);
        }

    }
}
