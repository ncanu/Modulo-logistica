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
using MantenimientosLinea;

namespace MantenimientosLinea
{
    public partial class InterfazMantenimientoLinea : Form
    {
        Navegador nv = new Navegador();
        public InterfazMantenimientoLinea(DataGridView dataGridView1)
        {
            nv.dgv_datos(dataGridView1);
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InterfazMantenimientoLinea_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("TBL_Linea");
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
