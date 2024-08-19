using Evaluacion1AppRegistroEquipoFootball.Models;
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
using System.Collections.Generic;

namespace Evaluacion1AppRegistroEquipoFootball
{
    /// <summary>
    /// Lógica de interacción para ListarEquiposPage.xaml
    /// </summary>
    public partial class ListarEquiposPage : Page
    {
        public ListarEquiposPage()
        {
            InitializeComponent();
            CargarEquipos(); // Llama al método para cargar los equipos guardados
        }

        private void CargarEquipos()
        {
            // Asignar la lista de equipos guardados al DataGrid
            dataGridEquipos.ItemsSource = null; // Limpiar la fuente de datos
            dataGridEquipos.ItemsSource = EquipoData.Equipos; // Asignar la lista actual de equipos
        }

        // Método para manejar la eliminación de un equipo
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el equipo seleccionado
            if (dataGridEquipos.SelectedItem is Equipo equipoSeleccionado)
            {
                // Eliminar el equipo de la lista estática
                EquipoData.Equipos.Remove(equipoSeleccionado);

                // Refrescar el DataGrid
                CargarEquipos(); // Recargar los equipos en la interfaz

                MessageBox.Show("Equipo eliminado exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un equipo para eliminar.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Método para manejar la actualización de un equipo
        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el equipo seleccionado
            if (dataGridEquipos.SelectedItem is Equipo equipoSeleccionado)
            {
                // Navegar a la página de actualización con el equipo seleccionado
                ActualizarEquipoPage actualizarPagina = new ActualizarEquipoPage(equipoSeleccionado);
                this.NavigationService.Navigate(actualizarPagina);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un equipo para actualizar.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}