using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            N.Maximum = int.MaxValue;
        }
        private int posled(int n)
        {
            if (n == 1)
                return -10;
            if (n == 2)
                return 2;
            return (Math.Abs(posled(n - 2)) - 6 * posled(n - 1));
        }
        private void N_ValueChanged(object sender, EventArgs e)
        {
            if (N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            Res.Text = posled((int)N.Value).ToString();
        }
    }
}
