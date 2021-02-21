using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MáquinaInferencia_Frutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BIniciar_Click(object sender, EventArgs e)
        {

            FormColor formp1 = new FormColor();
            formp1.Show();
            this.Hide();
                
        }


    }
}
