using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Evaluacion1AppRegistroEquipoFootball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Método para manejar la navegación al hacer clic en "Agregar Equipo"
        private void menuAgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AgregarEquipoPage());
        }
        // Método para manejar la navegación al hacer clic en "Listar Equipos"
        private void menuListarEquipos_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ListarEquiposPage());
        }
        // Método para manejar la navegación al hacer clic en "Acerca De"
        private void menuAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AcercaDePage());
        }  
    }
}