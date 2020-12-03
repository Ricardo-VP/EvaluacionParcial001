using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionParcial001.forms
{
    public partial class FormEvaluacion : Form
    {
        public FormEvaluacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRes.Text = Convert.ToString(clases.Ej1.formula());
        }
    }
}
