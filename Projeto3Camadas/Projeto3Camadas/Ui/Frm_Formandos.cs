using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas
{
    public partial class Form1 : Form
    {
        FormandoBLL forbll = new FormandoBLL();
        FormandoDTO fordto = new FormandoDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fordto.Nome = txtNome.Text;
            fordto.Local = txtLocal.Text;
            fordto.Cpf = int.Parse(txtCpf.Text);

            forbll.Inserir(fordto);

            MessageBox.Show("Cadastro com sucesso!", "Formando", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCpf.Clear();
            txtLocal.Clear();
            txtNome.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            fordto.Nome = txtNome.Text;
            fordto.Cpf = int.Parse(txtCpf.Text);
            fordto.Local = txtLocal.Text;

            forbll.Editar(fordto);

            MessageBox.Show("Alterado com sucesso!", "Formando", MessageBoxButtons.OK, MessageBoxIcon.Information);

            forbll.Listar();

            txtCpf.Clear();
            txtLocal.Clear();
            txtNome.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            fordto.Cpf = int.Parse(txtCpf.Text);

            forbll.Excluir(fordto);

            MessageBox.Show("Excluido com sucesso!", "Formando", MessageBoxButtons.OK, MessageBoxIcon.Information);

            forbll.Listar();

            txtCpf.Clear();
            txtLocal.Clear();
            txtNome.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFormandos.DataSource = forbll.Listar();
        }

        private void dgvFormandos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvFormandos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCpf.Text = dgvFormandos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLocal.Text = dgvFormandos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
