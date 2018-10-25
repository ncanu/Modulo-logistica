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

namespace MantenimientoMateriaPrima
{
    public partial class InterfazConsultaMateriaPrima : Form
    {
        Navegador nv = new Navegador();
        public InterfazConsultaMateriaPrima()
        {
            InitializeComponent();
        }

        private void InterfazMatenimientoMateriaPrima_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new InterfazMantenimientosMateriaPrima(dgr).Show();
        }

        private void InterfazConsultaMateriaPrima_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_MateriaPrima");
            dgr.DataSource = tabla;
        }
    }
}
