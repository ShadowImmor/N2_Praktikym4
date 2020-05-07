using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F.Minimum = decimal.MinValue;
            F.Maximum = decimal.MaxValue;
            Dif.Minimum = decimal.MinValue;
            Dif.Maximum = decimal.MaxValue;
            N.Maximum = int.MaxValue;
        }
        static void posled(decimal first, decimal dif, int n, ref decimal resln, ref decimal reslsum, int i = 1)
        {
            if (i == 1)
            {
                resln = first;
                reslsum = resln;
                posled(first, dif, n, ref resln, ref reslsum, i + 1);
            }
            else if (i <= n)
            {
                resln = resln + dif;
                reslsum += resln;
                posled(first, dif, n, ref resln, ref reslsum, i + 1);
            }
        }
        private void Rasbutton_Click(object sender, EventArgs e)
        {
            if (N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            decimal resln = 0, reslsum = 0;
            posled(F.Value, Dif.Value, (int)N.Value, ref resln, ref reslsum);
            ReslN.Text = resln.ToString();
            ReslSum.Text = reslsum.ToString();
        }
    }
}
