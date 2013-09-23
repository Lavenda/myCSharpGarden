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
        private int _scope = 260;
        private int bingoNum = 0;

        public mainFrom()
        {
            InitializeComponent();
        }


        private void showNumTimer_Tick(object sender, EventArgs e)
        {
            this.randomNum();
        }

        private void randomNum()
        {
            Random random = new Random();
            this.bingoNum = random.Next(_scope);
            this.numLab.Text = this._formatNum(this.bingoNum);
        }

        private void noFourInNum()
        {
            int bingoNumUnitDigit = 0;
            int bingoNumTensDigit = 0;
            int bingoNumHundreds = 0;

            do
            {
                this.randomNum();
                bingoNumUnitDigit = this.bingoNum % 10;
                bingoNumTensDigit = (this.bingoNum % 100) / 10;
                bingoNumHundreds = this.bingoNum / 100;
            } while (bingoNumUnitDigit == 4 || bingoNumTensDigit == 4 || bingoNumHundreds == 4);


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
                this.noFourInNum();
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
