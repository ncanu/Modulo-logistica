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
    public partial class InterfazMantenimientosMateriaPrima : Form
    {
        public InterfazMantenimientosMateriaPrima(DataGridView dgr)
        {
            Navegador nv = new Navegador();
            InitializeComponent();
            nv.dgv_datos(dgr);
        }

        private void InterfazConsultaMateriaPrima_Load(object sender, EventArgs e)
        {
            Navegador nv = new Navegador();
            nv.ingresarTabla("TBL_MateriaPrima");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
