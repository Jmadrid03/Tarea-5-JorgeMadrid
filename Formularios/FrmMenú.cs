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
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Porcentaje_de_Ganancia_de_un_Producto gana = new Formularios.FrmCalcular_el_Porcentaje_de_Ganancia_de_un_Producto();
            gana.Show();
        }

        private void BtnLitrosTanque_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_la_Cantidad_de_Litros_de_Agua lts = new Formularios.FrmCalcular_la_Cantidad_de_Litros_de_Agua();
            lts.Show();
        }

        private void BtnNotaE_Click(object sender, EventArgs e)
        {
            Formularios.FrmNota_de_Estudiante study = new Formularios.FrmNota_de_Estudiante();
            study.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Promedio_de_Estudiante_si_Aprobo_o_Reprobo prom = new Formularios.FrmCalcular_el_Promedio_de_Estudiante_si_Aprobo_o_Reprobo();
            prom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmFactura_de_Venta fact = new Formularios.FrmFactura_de_Venta();
            fact.Show();
        }
    }
}
