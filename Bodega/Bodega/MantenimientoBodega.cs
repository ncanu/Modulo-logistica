﻿using CapaDiseno;
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
    public partial class MantenimientoBodega : Form
    {

        Navegador nv = new Navegador();
        public MantenimientoBodega(DataGridView dataGridViewX)
        {
            InitializeComponent();
            nv.dgv_datos(dataGridViewX);
        }

        //public MantenimientoBodega()
        //{
        //    InitializeComponent();
        //}

        private void MantenimientoBodega_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("TBL_bodega");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
