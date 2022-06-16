using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WPFarchivos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int m, n, m2, n2;
        static double[,] datoA;
        static double[,] datoB;

        Matrices matA;
        Matrices matB;
        Matrices matC;
        Matrices matIn;
        Matrices mat2A;
        Matrices mat2B;
        Matrices mat2C;
        Matrices mat2In;
        Matrices matSuRe;
        Matrices matMul;

        TextBox[,] TbMat;
        TextBox[,] TbMat2;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void LeerMat()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matA.Elem[i, j] = double.Parse(TbMat[i, j].Text);
                }
            }
        }

        public void MostrarMat()
        {
            string aux;
            LbMat.Items.Add("Matriz A");
            for (int i = 0; i < m; i++)
            {
                aux = "";
                for (int j = 0; j < n; j++)
                {
                    aux += matA.Elem[i, j] + "\t";
                }
                aux += "\t";
                LbMat.Items.Add(aux);
            }

            TbIndi.Text = "Mostrando matriz";
        }

        private void BtTamaño_Click(object sender, RoutedEventArgs e)
        {
            m = int.Parse(Tbm.Text);
            n = int.Parse(Tbn.Text);
            int x = 0;
            int y = -20;
            matA = new Matrices(m, n);
            TbMat = new TextBox[m, n];
            StackPanel1.Children.Clear();
            TbIndi.Text = "Tamaño de la matriz " + m + "x" + n + " establecido";

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TbMat[i, j] = new TextBox();
                    TbMat[i, j].Width = 30;
                    TbMat[i, j].Height = 20;
                    TbMat[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    TbMat[i, j].VerticalAlignment = VerticalAlignment.Top;
                    if (j == 0)
                    {
                        TbMat[i, j].Margin = new Thickness(30 * j, x, 0, 0);
                    }

                    else
                    {
                        TbMat[i, j].Margin = new Thickness(30 * j, y, 0, 0);
                    }

                    StackPanel1.Children.Add(TbMat[i, j]);
                }
            }
        }

        private void BtMostrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LeerMat();
                MostrarMat();
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtTranspuesta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LeerMat();

                matB = new Matrices(n, m);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matB.Elem[i, j] = matA.Elem[j, i];
                    }
                }

                string aux;
                LbMat.Items.Add("Transpuesta de la matriz A");
                for (int i = 0; i < n; i++)
                {
                    aux = "";
                    for (int j = 0; j < m; j++)
                    {
                        aux += matB.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }

                TbIndi.Text = "Mostrando matriz transpuesta";
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtInversa_Click(object sender, RoutedEventArgs e)
        {
            if (m == n)
            {
                LeerMat();

                matIn = new Matrices(m, n);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matIn.Elem[i, j] = 0;
                        if (i == j)
                        {
                            matIn.Elem[i, j] = 1;
                        }
                    }
                }

                double pivote;
                double aux;

                for (int i = 0; i < m; i++)
                {
                    pivote = matA.Elem[i, i];
                    for (int k = 0; k < n; k++)
                    {
                        matA.Elem[i, k] = matA.Elem[i, k] / pivote;
                        matIn.Elem[i, k] /= pivote;
                    }

                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                        {
                            aux = matA.Elem[j, i];
                            for (int k = 0; k < n; k++)
                            {
                                matA.Elem[j, k] = matA.Elem[j, k] - aux * matA.Elem[i, k];
                                matIn.Elem[j, k] = matIn.Elem[j, k] - aux * matIn.Elem[i, k];
                            }
                        }
                    }
                }

                string aux2;
                LbMat.Items.Add("Inversa de la matriz A");
                for (int i = 0; i < n; i++)
                {
                    aux2 = "";
                    for (int j = 0; j < m; j++)
                    {
                        aux2 += matIn.Elem[i, j] + "\t";
                    }
                    aux2 += "\t";
                    LbMat.Items.Add(aux2);
                }

                TbIndi.Text = "Mostrando matriz inversa";

            }

            else
            {
                MessageBox.Show("La matriz no es cuadrada");
            }
        }

        private void BtDeterminante_Click(object sender, RoutedEventArgs e)
        {
            if (m == n)
            {
                LeerMat();

                double pivote, pivote1, aux;
                double det = 1;

                for (int i = 0; i < m; i++)
                {
                    pivote = matA.Elem[i, i];
                    for (int j = i + 1; j < n; j++)
                    {
                        pivote1 = matA.Elem[j, i];
                        aux = pivote1 / pivote;
                        for (int k = 0; k < m; k++)
                        {
                            matA.Elem[j, k] = matA.Elem[j, k] - aux * matA.Elem[i, k];
                        }
                    }
                }

                LbMat.Items.Add("Determinante de la matriz A");
                for (int i = 0; i < n; i++)
                {
                    det *= matA.Elem[i, i];
                }
                LbMat.Items.Add(det);

                TbIndi.Text = "Mostrando el determinante";
            }

            else
            {
                MessageBox.Show("La matriz no es cuadrada");
            }
        }

        private void BtFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature");
        }

        private void BtSalvar_Click(object sender, RoutedEventArgs e)
        {
            datoA = new double[m, n];
            StreamWriter salvar1 = new StreamWriter("MisdatosA");
            LeerMat();
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    datoA[i,j]=matA.Elem[i,j];
                    salvar1.WriteLine(datoA[i, j]);
                }
            }
            salvar1.Close();
            TbIndi.Text = "Salvando la matriz";
        }

        private void BtCargar_Click(object sender, RoutedEventArgs e)
        {
            string aux;
            StreamReader cargar1 = new StreamReader("MisdatosA");
            LbMat.Items.Add("Matriz A cargada");
            for(int i = 0; i < m; i++)
            {
                aux = "";
                for (int j=0; j < n; j++)
                {
                    datoA[i,j]=double.Parse(cargar1.ReadLine());
                    aux+=datoA[i,j] + "\t";
                }
                aux += "\t";
                LbMat.Items.Add(aux);
            }
            cargar1.Close();
            TbIndi.Text = "Cargando la matriz";
        }

        private void BtBorrar_Click(object sender, RoutedEventArgs e)
        {
            LbMat.Items.Clear();
        }
    }
}
