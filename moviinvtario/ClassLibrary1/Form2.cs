using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace ClassLibrary1
{
    public partial class Form2 : Form
    { Navegador nv = new Navegador();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_Movimientos_Inventario");
            dgv_mov_inventarios.DataSource = tabla;
        }

        private void dgv_mov_inventarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Form1(dgv_mov_inventarios).Show();
        }

        private void dgv_mov_inventarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
