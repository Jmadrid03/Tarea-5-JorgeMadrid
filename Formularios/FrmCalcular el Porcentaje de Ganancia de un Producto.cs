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
    public partial class FrmCalcular_el_Porcentaje_de_Ganancia_de_un_Producto : Form
    {
        Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos POO = new Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos();
        public FrmCalcular_el_Porcentaje_de_Ganancia_de_un_Producto()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtCosto.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Precio de Costo es Requerido.");
                TxtCosto.Focus();
            }
            if (TxtVenta.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Precio de Venta es Requerido.");
                TxtVenta.Focus();
            }

            double prec, prev;
            prec = Convert.ToDouble(TxtCosto.Text);
            prev = Convert.ToDouble(TxtVenta.Text);

            TxtPorcentaje.Text = POO.PorcGanan(prec, prev).ToString() + "%";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtCosto.Focus();
            }
        }

        private void TxtCosto_TextChanged(object sender, EventArgs e)
        {
            if (TxtCosto.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtCosto.Text);
            }
        }

        private void TxtVenta_TextChanged(object sender, EventArgs e)
        {
            if (TxtVenta.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtVenta.Text);
            }
        }
    }
}
