using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5_JorgeMadrid.Clases_de_Orientada_a_Objetos
{
    class Class_Programación_Orientada_Objetos
    {
        public double PorcGanan(double prec, double prev)
        {
            double res;
                double sub = prec - prev;
            res = sub / 100;
            return res;
        }

        public double Tanque(double larg, double anch, double alt)
        {
            double resl;
            resl = (larg * anch * alt) / 1000;
            return resl;
        }

        public void MsgWarning(string str)
        {
            MessageBox.Show(str, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AlertNotNumber(string str)
        {
            double x;
            if (!double.TryParse(str, out x))
            {
                MsgWarning("El Valor Debe Ser Númerico.");
            }
        }

        public string CheckIfIsNumber(string str)
        {
            string resp = "";
            double x;
            if (double.TryParse(str, out x))
            {
                resp = "S";
            }
            else
            {
                resp = "N";
            }
            return resp;
        }

        public double NotProm(double n1, double n2, double n3, double n4, double Ap, double Rp)
        {
            double res;
            res = (n1 + n2 + n3 + n4) / 4;
            Ap = 0;
            Rp = 0;
            if (res >= 65)
            {
                Ap++;
            }else
            {
                Rp++;
            }
            return res;
            
        }

        public double precU(double cant, double prec)
        {
            double resl;
            resl = cant * prec;
            return resl;
        }
        
        public double ExamProm(double nt1, double nt2, double nt3, double acuml)
        {
            double prom;
            prom = nt1 + nt2 + nt3 + acuml;
            return prom;
        }
    }
}
