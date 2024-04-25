using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using Ptc.MathcadPrime.Automation;

namespace CoursageCaban
{
    internal class Calculate
    {
        private double q, m, k;
        private string path = "C:\\Users\\31rom\\Documents\\2 курс\\1 семестр\\ЧМ\\лаб6\\Ll.mcdx";

        private double Q
        {
            get => q;
            set => q = value;
        }

        private double M
        {
            get => m;
            set => m = value;
        }

        private double K
        {
            get => k; 
            set => k = value;
        }

        public Calculate(double q, double m, double k)
        {
            Q = q; M = m; K = k;
        }

        public void CalculateData()
        {
            IMathcadPrimeApplication3 app = new ApplicationCreator();
            IMathcadPrimeWorksheet ws = app.Open(path);
            app.Visible = true;
            var answer = ws.InputGetRealValue("c");
            ws.SetRealValue("c", 0.3, "");

            int d = 5;
        }
    }
}
