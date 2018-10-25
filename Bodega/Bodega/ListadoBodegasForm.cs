using CapaDiseno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega
{
    public partial class ListadoBodegasForm : Form
    {
        Navegador nv = new Navegador();

        public ListadoBodegasForm()
        {
            InitializeComponent();
        }

        private void ListadoBodegasForm_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_bodega");
            dataGridView1.DataSource = tabla;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1!=null)
                {
                MantenimientoBodega mantenimientoBodega = new MantenimientoBodega(dataGridView1);
                mantenimientoBodega.Show();
            }
            
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
