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
    public partial class FrmNota_de_Estudiante : Form
    {
        Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos POO = new Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos();
        public FrmNota_de_Estudiante()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Nombre es Requerido.");
                TxtNombre.Focus();
                return;
            }
            if (TxtExamen1.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Nota Examen 1 es Requerido.");
                TxtExamen1.Focus();
                return;
            }
            if (TxtExamen2.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Examen 2 es Requerido.");
                TxtExamen2.Focus();
                return;
            }
            if (TxtExamen3.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Examen 3 es Requerido.");
                TxtExamen3.Focus();
                return;
            }
            if (TxtAcumulativo.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Acumulativo es Requerido.");
                TxtAcumulativo.Focus();
                return;
            }

            LsbNombreE.Items.Add(TxtNombre.Text.Trim());
            LsbNot1.Items.Add(TxtExamen1.Text.Trim());
            LsbNot2.Items.Add(TxtExamen2.Text.Trim());
            LsbNot3.Items.Add(TxtExamen3.Text.Trim());
            LsbAcumulativo.Items.Add(TxtAcumulativo.Text.Trim());

            double n1, n2, n3, acum;

            n1 = Convert.ToDouble(TxtExamen1.Text);
            n2 = Convert.ToDouble(TxtExamen2.Text);
            n3 = Convert.ToDouble(TxtExamen3.Text);
            acum = Convert.ToDouble(TxtAcumulativo.Text);

            double prom = n1 + n2 + n3 + acum;

            if (prom >= 65)
            {
                LsbCondicion.Items.Add("APROBADO");
            }
            else
            {
                LsbCondicion.Items.Add("REPROBADO");
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtNombre.Focus();
            }
        }

        private void TxtExamen1_TextChanged(object sender, EventArgs e)
        {
            if(TxtExamen1.Text.Trim().Length >= 0)
            {
                POO.MsgWarning("El Valor debe ser numerico.");
                TxtExamen1.Focus();
            }
        }
    }
}
