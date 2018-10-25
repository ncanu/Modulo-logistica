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

namespace MantenimientoSedes
{
    public partial class SedesLogistica : Form
    {
        Navegador nv = new Navegador();
        public SedesLogistica()
        {
            InitializeComponent();
            
        }

        private void SedesLogistica_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_sede");
            dgv_Sedes.DataSource = tabla;
        }

        private void dgv_Sedes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new InterfazMantenimientoSede(dgv_Sedes).Show();
        }
    }
}
