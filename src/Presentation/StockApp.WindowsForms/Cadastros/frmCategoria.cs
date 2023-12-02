using StockApp.Business.Entidades;
using StockApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.WindowsForms.Cadastros
{
    public partial class frmCategoria : Form
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public frmCategoria()
        {
            InitializeComponent();
           
           
        }
        public frmCategoria(ICategoriaRepositorio categorias)
        {
            _categoriaRepositorio = categorias;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novaCategoria = new Categoria();
            novaCategoria.Nome = txtNome.Text;
            novaCategoria.Status = chkStatus.Checked;   

            var resultado = _categoriaRepositorio.Incluir(novaCategoria);

            if(resultado)
            {
                MessageBox.Show("O deu certo","Olha",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O deu errado", "Olha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
