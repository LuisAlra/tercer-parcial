using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_calculadora1
{
    internal class calculadora
    {
        public calculadora()
        {


        }
        public string sumaXY(double x, double y, ref double r)
        {
            r = x + y;
            return ("+");
        }

        public string restaXY(double x, double y, ref double r)
        {
            r = x - y;
            return ("-");

        }
        public string multiplicaXY(double x, double y, ref double r)
        {
            r = x * y;
            return ("*");
        }

        public string divisionXY(double x, double y, ref double r)
        {
            r = x / y;
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("/");
        }
        public string cosXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Cos(x);

            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("cos");

        }
        public string senXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Sin(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("sen");
        }
        public string tanXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Tan(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("tan");
        }
        public string senhXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Sinh(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("senh");
        }
        public string coshXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Cosh(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("cosh");
        }
        public string tanhXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Tanh(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("tanh");
        }
        public string arcsenXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Asin(r);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("arcseh");
        }
        public string arccosXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Acos(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("arccos");
        }
        public string arctanXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = Math.Atan(r);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("arctan");
        }
        public string cscXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = 1 / Math.Sin(r);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("csc");
        }
        public string secXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = 1 / Math.Cos(r);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("sec");
        }
        public string cotXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = 1 / Math.Tan(r);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("ctg");
        }
        public string factorial(double x, ref double r)
        {
            int fact = int.Parse(x.ToString());

            if (fact == 0)
                r = 1;
            else
            {
                for (int icon = int.Parse(x.ToString()); icon > 1; icon--)
                {
                    fact = fact * (icon - 1);
                }

            }
            r = double.Parse(fact.ToString());


            return ("!");
        }
        public string log(double x, ref double r)
        {
            r = Math.Log10(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("log");
        }
        public string lognat(double x, ref double r)
        {
            r = Math.Log(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("ln");
        }
        public string potcuadrado(double x, ref double r)
        {
            r = Math.Pow(x, 2);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("²");
        }
        public string potcubica(double x, ref double r)
        {
            r = Math.Pow(x, 3);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("³");
        }
        public string raiz(double x, ref double r)
        {
            r = Math.Sqrt(x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("^½");
        }
        public string xalay(double x, double y, ref double r)
        {
            r = Math.Pow(x, y);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("^");
        }
        public string euler(double x, ref double r)
        {
            r = Math.Pow(Math.E, x);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("e^");
        }

        public string absoluto(double x, ref double r)
        {
            r = Math.Abs(x);
            return ("|");
        }
        public string arccotXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = 1 / Math.Atan(r);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("arctan");
        }
        public string arcsecXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = 1 / Math.Acos(r);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("arctan");
        }
        public string arccscXY(double x, ref double r)
        {
            x = x * Math.PI / 180;
            r = 1 / Math.Asin(r);
            r = Math.Round(r, 4); //redondear a cuatro decimales
            return ("arctan");
        }
    }
}
