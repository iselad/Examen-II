using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXAMEN_II_Rosaysela
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        Usuariofrm frmusuarios = null;
         pedidos frmpedidos =null;
         Productofrm frm = null;

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (frmusuarios == null) {
                frmusuarios = new Usuariofrm();
                frmusuarios.MdiParent = this;
                frmusuarios.Show();
            }
            else
            {
                frmusuarios.Activate(); 
            }
          

        }

       

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new Productofrm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Activate();
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            if (frmpedidos == null)
            {
                frmpedidos = new pedidos();
                frmpedidos.MdiParent = this;
                frmpedidos.Show();
            }
            else
            {
                frmpedidos.Activate();
            }

        }
    }
}
