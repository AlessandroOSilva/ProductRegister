using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Relational;
using ProductRegister.Data;
using ProductRegister.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductRegister
{
    public partial class FrmListagem : Form
    {
        public FrmListagem()
        {
            InitializeComponent();
        }

        private void FrmListagem_Load_1(object sender, EventArgs e)
        {
            using (var context = new ProductContext())
            {
                dataGridView1.DataSource = context.Products.ToList();
            }
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                if(column.Name == "Id")
                {
                    column.Visible = false;
                }

                column.Width = 200;
            }
        }

    }
}
