namespace MAUI_calculadora1;
using info.lundin.math;

public partial class MainPage : ContentPage
{
	double x, y, r;
    string fdex, fdexy;
	string Rsalida;
	Calcualdora_class Mical;

	public MainPage()
	{
        int n = 1000;
		InitializeComponent();
        Mical = new Calcualdora_class(n);
	}

    private void btn_suma(object sender, EventArgs e)
    {
        try
        {
            Entrada1();
            Rsalida = Mical.sumaXY(x, y, ref r);
            Salida1(r);
        }
        catch 
        {
            DisplayAlert("ERROR","Error Entrada-Proceso-Salida","OK");
        }
		

    }

    private void btn_resta(object sender, EventArgs e)
    {
        try
        {
            Entrada1();
            Rsalida = Mical.restaXY(x, y, ref r);
            Salida1(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }

    private void btn_div(object sender, EventArgs e)
    {
        try
        {
            Entrada1();
            Rsalida = Mical.divisionXY(x, y, ref r);
            Salida1(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }
    }
    private void btn_mul(object sender, EventArgs e)
    {
        try
        {
            Entrada1();
            Rsalida = Mical.multiplicaXY(x, y, ref r);
            Salida1(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }
    }

    private void btn_raiz(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.raiz(x, ref r);
            datoy.Text = "";
            Salida1(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }

    private void btn_alcuadrado(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.potcuadrado(x, ref r);
            datoy.Text = "";
            Salida1(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }

    private void btn_ln(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.lognat(x, ref r);
            datoy.Text = "";
            Salida2(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }
    }

    private void btn_log(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.log(x, ref r);
            datoy.Text = "";
            Salida2(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }

    private void btn_diezalax(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            r = Math.Pow(10,x);
            Rsalida = "10^";
            datoy.Text = "";
            Salida2(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }

    private void btn_ealax(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.euler(x, ref r);
            datoy.Text = "";
            Salida2(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }

    private void btn_abs(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.absoluto(x, ref r);
            datoy.Text = "";
            Salida2(r);
            oper.Text = "|";
        }
            
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }

    private void btn_fac(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.factorial(x, ref r);
            datoy.Text = "";
            Salida1(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }



    private void btn_sen(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.senXY(x,ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_cos(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.cosXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_tan(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.tanXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }


    }

    private void btn_cot(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.cotXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_sec(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.secXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_csc(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.cscXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_asen(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.arcsenXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_acos(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.arccosXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_atan(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.arctanXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_acot(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.arccotXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }
    }

    private void btn_asec(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.arctanXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }

    }

    private void btn_acsc(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = Mical.arccscXY(x, ref r);
            Salida2(r);

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");
        }
    }

    private void btn_firma(object sender, EventArgs e)
    {
        DisplayAlert("Firma", "Cruz Lara Luis Ángel\nBoleta: 2019301685\nNL: 6\nGrupo:8CM11", "ok");
    }

    public void Salida1(double r)
	{
        datoy.IsVisible = true;
        trigo.Text = "";
        oper.Text = Rsalida;
		Resultado.Text = r.ToString();
	}
    public void Salida2(double r)
    {
        datoy.IsVisible = false;
        oper.Text = "";
        trigo.Text = Rsalida;
        
        Resultado.Text = r.ToString();
    }
    public void Salida3(double r)
    {
        datoy.IsVisible = false;
        oper.Text = "";
        trigo.Text = "";

        Resultado.Text = r.ToString();
    }
    public void Salida4(double r)
    {
        datoy.IsVisible = true;
        oper.Text = "";
        trigo.Text = "";
        Resultado.Text = r.ToString();
    }

    private void btn_fxy(object sender, EventArgs e)
    {
        Entrada1();
        Mical.Fx2(x,y,fdexy, ref r);
        Salida4(r);
    }

    private void btn_integrarFx(object sender, EventArgs e)
    {
        Entrada1();
        r = Mical.CalcuIntegrales(x,y,fdex);
        Salida4(r);
    }

    private void btn_fx(object sender, EventArgs e)
    {
        Entrada2();
        Mical.fx(x,fdex,ref r);
        Salida3(r);
    }

    //funciones para entrada de datos
    public void Entrada1()
    {
        try
        {
            x = double.Parse(datox.Text);
            y = double.Parse(datoy.Text);
            fdexy = datofxy.Text;
            fdex = datofx.Text;


        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");

        }
        

    }
    public void Entrada2()
    {
        try
        {
            x = double.Parse(datox.Text);
            fdex = datofx.Text;
            

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");

        }

    }
}

