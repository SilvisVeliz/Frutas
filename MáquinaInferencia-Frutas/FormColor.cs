using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MáquinaInferencia_Frutas
{
    public partial class FormColor : Form
    {
        public FormColor()
        {
            InitializeComponent();
        }

        private void Pregunta1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCascara frCasca = new FormCascara;
            frCasca.Show();
            this.Hide();
        }
    }
}
