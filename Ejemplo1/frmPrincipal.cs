using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)//este ciclo nos sirve para iterar sobre la coleccion
            {                                           // y si la ventana que queremos abrir ya esta abiera
                if (item.GetType() == typeof(Form1))    //corta la ejecucion alli, y no sigue abriendo la misma ventana cada vez que se aprieta el boton
                {
                    return;
                }
            }

            Form1 Ventana = new Form1();
            Ventana.MdiParent = this;//para que alla una ventana padre y contenga a la que vayas a abrir, no que abra aparte.
            Ventana.Show();

        }

        private void tsPerfilPersona_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    return;
                }
            }
            Form1 Ventana = new Form1();
            Ventana.MdiParent = this;
            Ventana.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
