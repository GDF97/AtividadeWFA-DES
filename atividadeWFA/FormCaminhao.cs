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
    public partial class FormCaminhao : Form
    {
        public FormCaminhao()
        {
            InitializeComponent();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFabricante.Text = "";
            txtAno.Text = "";
            txtCor.Text = "";
            txtCarga.Text = "";
            txtEixos.Text = "";
            txtPlaca.Text = "";
            cbModelo.Text = null;
            cbTipoCarroceria.Text = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbModelo.Text == "" || txtPlaca.Text == "" || txtFabricante.Text == "" || txtCor.Text == ""
                || txtAno.Text == "" || cbTipoCarroceria.Text == "" || txtCarga.Text == "" || txtEixos.Text == "")
            {
                MessageBox.Show("Verifique se as informações estão corretas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtAno.TextLength < 4)
                {
                    MessageBox.Show("Verifique se o ano é valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dvgDadosCaminhao.Rows.Add(cbModelo.Text, txtFabricante.Text, txtAno.Text, txtCor.Text,
                        txtPlaca.Text, txtCarga.Text, cbTipoCarroceria.Text, txtEixos.Text);
                    MessageBox.Show("Cadastrado", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Deseja remover a linha: " + (dvgDadosCaminhao.CurrentRow.Cells[0].RowIndex + 1);
            string caption = "Alerta!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                dvgDadosCaminhao.Rows.RemoveAt(dvgDadosCaminhao.CurrentRow.Cells[0].RowIndex);
            }
            else
            {
                MessageBox.Show("OK Sem problemas!", "Resposta NÃO", MessageBoxButtons.OK);
            }
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            string message = "Concluir essa ação fará com que todas as informações sejam apagadas. Tem certeza que é isso que quer fazer?";
            string caption = "Alerta!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                dvgDadosCaminhao.Rows.Clear();
            }
            else
            {
                MessageBox.Show("OK Sem problemas!", "Resposta NÃO", MessageBoxButtons.OK);
            }
        }

        private void FormCaminhao_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 255);
            btnCadastrar.BackColor = Color.FromArgb(67, 154, 134);
            btnLimpar.BackColor = Color.FromArgb(67, 154, 134);
            btnExcluir.BackColor = Color.FromArgb(67, 154, 134);
            btnLimparTudo.BackColor = Color.FromArgb(67, 154, 134);
            tabPage1.BackColor = Color.FromArgb(247, 247, 255);
            tabPage2.BackColor = Color.FromArgb(247, 247, 255);
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEixos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
