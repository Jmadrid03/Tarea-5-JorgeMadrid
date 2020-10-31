using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5_JorgeMadrid.Formularios
{
    public partial class FrmCalcular_el_Promedio_de_Estudiante_si_Aprobo_o_Reprobo : Form
    {
        Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos POO = new Clases_de_Orientada_a_Objetos.Class_Programación_Orientada_Objetos();
        public FrmCalcular_el_Promedio_de_Estudiante_si_Aprobo_o_Reprobo()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtNombreE.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Nombre es Requerido.");
                TxtNombreE.Focus();
                return;
            }
            if (TxtNota1.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Nota 1 es Requerido.");
                TxtNota1.Focus();
                return;
            }
            if (TxtNota2.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Nota 2 es Requerido.");
                TxtNota2.Focus();
                return;
            }
            if (TxtNota3.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Nota 3 es Requerido.");
                TxtNota3.Focus();
                return;
            }
            if (TxtNota4.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Nota 4 es Requerido.");
                TxtNota4.Focus();
                return;
            }

            if (POO.CheckIfIsNumber(TxtNota1.Text.Trim()) == "N")
            {
                POO.MsgWarning("El Valor en El Campo Nota 1 Debe Ser Numerico.");
                TxtNota1.Focus();
                return;
            }

            if (POO.CheckIfIsNumber(TxtNota2.Text.Trim()) == "N")
            {
                POO.MsgWarning("El Valor En El Campo Nota 2 Debe Ser Numerico.");
                TxtNota2.Focus();
                return;
            }

            if (POO.CheckIfIsNumber(TxtNota3.Text.Trim()) == "N")
            {
                POO.MsgWarning("El Valor En El Campo Nota 3 Debe Ser Numerico.");
                TxtNota3.Focus();
                return;
            }

            if (POO.CheckIfIsNumber(TxtNota4.Text.Trim()) == "N")
            {
                POO.MsgWarning("El Valor En El Campo Nota 4 Debe Ser Numerico.");
                TxtNota4.Focus();
                return;
            }

            string nomb, n1, n2, n3, n4, prom;

            nomb = TxtNombreE.Text.Trim();
            n1 = TxtNota1.Text.Trim();
            n2 = TxtNota2.Text.Trim();
            n3 = TxtNota3.Text.Trim();
            n4 = TxtNota4.Text.Trim();
            prom = TxtPromedioE.Text.Trim();

            DgvDatosE.Rows.Add(nomb, n1, n2, n3, n4, prom);

            TxtNombreE.Clear();
            TxtNota1.Clear();
            TxtNota2.Clear();
            TxtNota3.Clear();
            TxtNota4.Clear();
            TxtPromedioE.Clear();
            TxtNombreE.Focus();
        }

        private void TxtNota1_TextChanged(object sender, EventArgs e)
        {
            if (TxtNota1.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtNota1.Text.Trim());
            }
        }

        private void TxtNota2_TextChanged(object sender, EventArgs e)
        {
            if (TxtNota2.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtNota2.Text.Trim());
            }
        }

        private void TxtNota3_TextChanged(object sender, EventArgs e)
        {
            if (TxtNota3.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtNota3.Text.Trim());
            }
        }

        private void TxtNota4_TextChanged(object sender, EventArgs e)
        {
            if (TxtNota4.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtNota4.Text.Trim());
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double nt1, nt2, nt3, nt4, Ap, Rp; 
            Ap = 0; Rp = 0;
            nt1 = Convert.ToDouble(TxtNota1.Text.Trim());
            nt2 = Convert.ToDouble(TxtNota2.Text.Trim());
            nt3 = Convert.ToDouble(TxtNota3.Text.Trim());
            nt4 = Convert.ToDouble(TxtNota4.Text.Trim());

            TxtAprobado.Text = Convert.ToString(Ap);
            TxtReprobado.Text=Convert.ToString(Rp);

            TxtPromedioE.Text = POO.NotProm(nt1, nt2, nt3, nt4, Ap, Rp).ToString() + "%";
            

        }
    }
}
