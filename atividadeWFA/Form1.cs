using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 255);
            btnCaminhao.BackColor = Color.FromArgb(67, 154, 134);
            btnCarro.BackColor = Color.FromArgb(67, 154, 134);
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            FormCarro carroTela = new FormCarro();
            carroTela.ShowDialog();
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            FormCaminhao caminhaoTela = new FormCaminhao();
            caminhaoTela.ShowDialog();
        }
    }
}
