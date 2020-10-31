using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5_JorgeMadrid.Formularios
{
    public partial class FrmFactura_de_Venta : Form
    {
        Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos POO = new Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos();
        public FrmFactura_de_Venta()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Codigo Es Requerido.");
                TxtCodigo.Focus();
                return;
            }
            if (TxtProducto.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Decripción Es Requerido.");
                TxtProducto.Focus();
                return;
            }
            if (TxtCantidad.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Cantidad Es Requerido.");
                TxtCantidad.Focus();
                return;
            }
            if (TxtPrecioU.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Precio Unitario Es Requerido.");
                TxtPrecioU.Focus();
                return;
            }

            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(DgvFactura);
            fila.Cells[0].Value = TxtCodigo.Text.Trim();
            fila.Cells[1].Value = TxtProducto.Text.Trim();
            fila.Cells[2].Value = TxtCantidad.Text.Trim();
            fila.Cells[3].Value = TxtPrecioU.Text.Trim();

            double prec, cant;
            prec = Convert.ToDouble(TxtPrecioU.Text.Trim());
            cant = Convert.ToDouble(TxtCantidad.Text.Trim());

            fila.Cells[4].Value = POO.precU(prec, cant).ToString();

            DgvFactura.Rows.Add(fila);

            TxtCodigo.Clear();
            TxtProducto.Clear();
            TxtCantidad.Clear();
            TxtPrecioU.Clear();
            TxtCodigo.Focus();
            
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (TxtCodigo.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtCodigo.Text.Trim());
                TxtCodigo.Focus();
                return;
            }
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (TxtCantidad.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtCantidad.Text.Trim());
                TxtCantidad.Focus();
                return;
            }
        }

        private void TxtPrecioU_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioU.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtPrecioU.Text.Trim());
                TxtPrecioU.Focus();
                return;
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Resl = 0, Impto = 0, Totp = 0;

            foreach(DataGridViewRow fila in DgvFactura.Rows)
            {
                Resl += Convert.ToDouble(fila.Cells["DcMonto"].Value);
            }

            Impto = Resl * 0.15;
            Totp = Impto + Resl;

            TxtSubT.Text = Convert.ToString(Resl);
            TxtImpto.Text = Convert.ToString(Impto);
            TxtTotalP.Text = Convert.ToString(Totp);
        }
    }
}
