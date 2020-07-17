using Microsoft.EntityFrameworkCore;
using ProductRegister.Data;
using ProductRegister.Entities;
using ProductRegister.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductRegister
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string name = txbNome.Text;
            string tipo = cbbTipo.Text;
            double preco = double.Parse(txbPreco.Text, CultureInfo.InvariantCulture);

            Product p = new Product(name, tipo, preco);

            using(DbContext context = new ProductContext())
            {
                context.Add(p);
                context.SaveChanges();
            }
            txbNome.Clear();
            txbPreco.Clear();

        }

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTipo.DataSource = Enum.GetValues(typeof(EnumType));

        }

    }
}
