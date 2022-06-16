namespace MAUI_calculadora1;

public partial class MainPage : ContentPage
{
    double x, y, r;
    string Rsalida;
    calculadora cal;

    public MainPage()
    {
        InitializeComponent();
        cal = new calculadora();
    }

    private void btn_suma(object sender, EventArgs e)
    {
        try
        {
            Entrada1();
            Rsalida = cal.sumaXY(x, y, ref r);
            Salida1(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }


    }

    private void btn_resta(object sender, EventArgs e)
    {
        try
        {
            Entrada1();
            Rsalida = cal.restaXY(x, y, ref r);
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
            Rsalida = cal.divisionXY(x, y, ref r);
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
            Rsalida = cal.multiplicaXY(x, y, ref r);
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
            Rsalida = cal.raiz(x, ref r);
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
            Rsalida = cal.potcuadrado(x, ref r);
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
            Rsalida = cal.lognat(x, ref r);
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
            Rsalida = cal.log(x, ref r);
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
            r = Math.Pow(10, x);
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
            Rsalida = cal.euler(x, ref r);
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
            Rsalida = cal.absoluto(x, ref r);
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
            Rsalida = cal.factorial(x, ref r);
            datoy.Text = "";
            Salida1(r);
        }
        catch
        {
            DisplayAlert("ERROR", "Error Entrada-Proceso-Salida", "OK");
        }

    }

    public void Entrada1()
    {
        try
        {
            x = double.Parse(datox.Text);
            y = double.Parse(datoy.Text);

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

        }
        catch
        {
            DisplayAlert("Error de Datos", "Revise datos de entrada", "OK");

        }

    }

    private void btn_sen(object sender, EventArgs e)
    {
        try
        {
            Entrada2();
            Rsalida = cal.senXY(x, ref r);
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
            Rsalida = cal.cosXY(x, ref r);
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
            Rsalida = cal.tanXY(x, ref r);
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
            Rsalida = cal.cotXY(x, ref r);
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
            Rsalida = cal.secXY(x, ref r);
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
            Rsalida = cal.cscXY(x, ref r);
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
            Rsalida = cal.arcsenXY(x, ref r);
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
            Rsalida = cal.arccosXY(x, ref r);
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
            Rsalida = cal.arctanXY(x, ref r);
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
            Rsalida = cal.arccotXY(x, ref r);
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
            Rsalida = cal.arctanXY(x, ref r);
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
            Rsalida = cal.arccscXY(x, ref r);
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
}

