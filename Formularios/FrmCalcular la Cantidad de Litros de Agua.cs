using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5_JorgeMadrid.Formularios
{
    public partial class FrmCalcular_la_Cantidad_de_Litros_de_Agua : Form
    {
        Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos POO = new Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos();
        public FrmCalcular_la_Cantidad_de_Litros_de_Agua()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtLargo.Text.Trim().Length == 0)
            {
                POO.MsgWarning("Ingresar el Largo del Tanque.");
                TxtLargo.Focus();
            }
            if (TxtAlto.Text.Trim().Length == 0)
            {
                POO.MsgWarning("Inngresar el Alto del Tanque.");
                TxtAlto.Focus();
            }
            if (TxtAncho.Text.Trim().Length == 0)
            {
                POO.MsgWarning("Ingresar el Ancho del Tanque.");
                TxtAncho.Focus();
            }

            double lar, alt, anch;
            lar = Convert.ToDouble(TxtLargo.Text.Trim());
            alt = Convert.ToDouble(TxtAlto.Text.Trim());
            anch = Convert.ToDouble(TxtAncho.Text.Trim());

            TxtResultado.Text = POO.Tanque(lar, alt, anch).ToString();

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtLargo.Focus();
            }
        }

        private void TxtLargo_TextChanged(object sender, EventArgs e)
        {
            if (TxtLargo.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtLargo.Text);
            }
        }

        private void TxtAlto_TextChanged(object sender, EventArgs e)
        {
            if (TxtAlto.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtAlto.Text);
            }
        }

        private void TxtAncho_TextChanged(object sender, EventArgs e)
        {
            if (TxtAncho.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtAncho.Text);
            }
        }
    }
}
