﻿using System;
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
    public partial class InterfazMantenimientoSede : Form
    {
        Navegador nv = new Navegador();
        public InterfazMantenimientoSede(DataGridView dgv_Sedes)
        {
            InitializeComponent();
            nv.dgv_datos(dgv_Sedes);
            
        }

        private void InterfazMantenimientoSede_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("TBL_Sede");
        }
    }
}
