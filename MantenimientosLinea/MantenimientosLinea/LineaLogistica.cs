using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MantenimientosLinea;
using CapaDiseno;

namespace MantenimientosLinea
{
    public partial class LineaLogistica : Form
    {
        Navegador nv = new Navegador();
        public LineaLogistica()
        {
            InitializeComponent();
        
        }

        private void Btn_cerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LineaLogistica_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_Linea");
            dataGridView1.DataSource = tabla;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new InterfazMantenimientoLinea(dataGridView1).Show();
        }
    }
}
