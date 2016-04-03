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
using Cotizacion.BLL;

namespace Cotizacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LivianoBLL lbll = new LivianoBLL();
            CmbTipo.ItemsSource = lbll.ListadoTipos();
            DgTabla.ItemsSource = lbll.ObtenerTodos();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LivianoBLL lbll = new LivianoBLL();
            MessageBox.Show(lbll.ObtenerPermiso(TxtCodigo.Text.Trim().ToUpper(), Convert.ToInt32(TxtAnno.Text.Trim())));                     
        }

        private void CmbTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LivianoBLL lbll = new LivianoBLL();
            CmbMarcas.ItemsSource = null;
            CmbAnno.ItemsSource = null;
            try
            {
                CmbMarcas.ItemsSource = lbll.ListadoMarcas(CmbTipo.SelectedValue.ToString());
                DgTabla.ItemsSource = lbll.ObtenerPorTipo(CmbTipo.SelectedValue.ToString());
            }
            catch 
            {
            }
        }

        private void CmbMarcas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LivianoBLL lbll = new LivianoBLL();
            CmbAnno.ItemsSource = null;
            try
            {
                CmbAnno.ItemsSource = null;
                CmbAnno.ItemsSource = lbll.ListadoAnnos(CmbTipo.SelectedValue.ToString(), CmbMarcas.SelectedValue.ToString());
                DgTabla.ItemsSource = lbll.ObtenerPorMarca(CmbTipo.SelectedValue.ToString(), CmbMarcas.SelectedValue.ToString());
            }
            catch (Exception)
            {
                CmbAnno.ItemsSource = null;
            }
            
        }

        private void CmbAnno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LivianoBLL lbll = new LivianoBLL();
            try
            {
                CmbCilindros.ItemsSource = null;
                CmbCilindros.ItemsSource = lbll.ListadoCilindros(CmbTipo.SelectedValue.ToString(), CmbMarcas.SelectedValue.ToString(), Convert.ToInt32(CmbAnno.SelectedValue.ToString()));
                DgTabla.ItemsSource = lbll.ObtenerPorAnno(CmbTipo.SelectedValue.ToString(), Convert.ToInt32(CmbAnno.SelectedValue.ToString()), CmbMarcas.SelectedValue.ToString());
            }
            catch (Exception)
            {
                CmbCilindros.ItemsSource = null;
            }
        }

        private void CmbCilindros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LivianoBLL lbll = new LivianoBLL();
            try
            {
               CmbPuertas.ItemsSource = null;
               CmbPuertas.ItemsSource = lbll.ListadoPuertas(CmbTipo.SelectedValue.ToString(), CmbMarcas.SelectedValue.ToString(), Convert.ToInt32(CmbAnno.SelectedValue.ToString()), CmbCilindros.SelectedValue.ToString());
               DgTabla.ItemsSource = lbll.ObtenerPorCilindrada(CmbTipo.SelectedValue.ToString(), Convert.ToInt32(CmbAnno.SelectedValue.ToString()), CmbMarcas.SelectedValue.ToString(), CmbCilindros.SelectedValue.ToString());
            }
            catch (Exception)
            {
                CmbPuertas.ItemsSource = null;
            }
        }

        private void CmbPuertas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LivianoBLL lbll = new LivianoBLL();
            try
            {
                CmbTransmision.ItemsSource = null;
                CmbTransmision.ItemsSource = lbll.ListadoTransmision(CmbTipo.SelectedValue.ToString(), CmbMarcas.SelectedValue.ToString(), Convert.ToInt32(CmbAnno.SelectedValue.ToString()), CmbCilindros.SelectedValue.ToString(), CmbPuertas.SelectedValue.ToString());
                DgTabla.ItemsSource = lbll.ObtenerPorPuertas(CmbTipo.SelectedValue.ToString(), Convert.ToInt32(CmbAnno.SelectedValue.ToString()), CmbMarcas.SelectedValue.ToString(), CmbCilindros.SelectedValue.ToString(), CmbPuertas.SelectedValue.ToString());
            }
            catch (Exception)
            {
                CmbTransmision.ItemsSource = null;
            }
        }

        private void CmbTransmision_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LivianoBLL lbll = new LivianoBLL();
            try
            {
                DgTabla.ItemsSource = lbll.ObtenerPorTransmision(CmbTipo.SelectedValue.ToString(), Convert.ToInt32(CmbAnno.SelectedValue.ToString()), CmbMarcas.SelectedValue.ToString(), CmbCilindros.SelectedValue.ToString(), CmbPuertas.SelectedValue.ToString(), CmbTransmision.SelectedValue.ToString());
            }
            catch (Exception)
            {
                CmbTransmision.ItemsSource = null;
            }
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LivianoBLL lbll = new LivianoBLL();
            CmbTransmision.ItemsSource = null;
            CmbPuertas.ItemsSource = null;
            CmbCilindros.ItemsSource = null;
            CmbAnno.ItemsSource = null;
            CmbMarcas.ItemsSource = null;
            CmbTipo.ItemsSource = null;
            CmbTipo.ItemsSource = lbll.ListadoTipos();
            DgTabla.ItemsSource = lbll.ObtenerTodos();
            TxtAnno.Text = "";
            TxtCodigo.Text = "";
                        
        }
    }
}
