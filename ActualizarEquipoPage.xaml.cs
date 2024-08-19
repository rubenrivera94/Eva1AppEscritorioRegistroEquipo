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

namespace Evaluacion1AppRegistroEquipoFootball
{
    /// <summary>
    /// Lógica de interacción para ActualizarEquipoPage.xaml
    /// </summary>
    public partial class ActualizarEquipoPage : Page
    {
        // Declarar la variable equipoSeleccionado
        private Equipo equipoSeleccionado;

        public ActualizarEquipoPage(Equipo equipo)
        {
            InitializeComponent();

            // Inicializar la variable equipoSeleccionado con el equipo pasado como parámetro
            equipoSeleccionado = equipo;

            // Cargar los datos del equipo seleccionado en los campos del formulario
            txtNombreEquipo.Text = equipoSeleccionado.NombreEquipo;
            // Convertimos el valor entero a texto para mostrarlo en el TextBox
            txtCantidadJugadores.Text = equipoSeleccionado.CantidadJugadores.ToString();
            txtNombreDT.Text = equipoSeleccionado.NombreDT;
            txtTipoEquipo.Text = equipoSeleccionado.TipoEquipo;
            txtCapitanEquipo.Text = equipoSeleccionado.CapitanEquipo;
            chkTieneSub21.IsChecked = equipoSeleccionado.TieneSub21 == true;
        }

        // Maneja el clic en el botón de actualizar para guardar los datos del equipo
        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtNombreEquipo.Text) ||
                string.IsNullOrEmpty(txtCantidadJugadores.Text) ||
                string.IsNullOrEmpty(txtNombreDT.Text) ||
                string.IsNullOrEmpty(txtTipoEquipo.Text) ||
                string.IsNullOrEmpty(txtCapitanEquipo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Validar que la cantidad de jugadores sea un número válido
            if (!int.TryParse(txtCantidadJugadores.Text, out _))
            {
                MessageBox.Show("La cantidad de jugadores debe ser un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Actualizar los datos del equipo
            equipoSeleccionado.NombreEquipo = txtNombreEquipo.Text;
            equipoSeleccionado.CantidadJugadores = int.Parse(txtCantidadJugadores.Text); // Convertir el texto a int
            equipoSeleccionado.NombreDT = txtNombreDT.Text;
            equipoSeleccionado.TipoEquipo = txtTipoEquipo.Text;
            equipoSeleccionado.CapitanEquipo = txtCapitanEquipo.Text;
            equipoSeleccionado.TieneSub21 = chkTieneSub21.IsChecked == true ? true : false;

            // Confirmar la actualización
            MessageBox.Show("Equipo actualizado exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

            // Navegar de vuelta a la lista de equipos
            NavigationService?.Navigate(new ListarEquiposPage());
        }

        // Maneja el clic en el botón de cancelar
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Navegar de vuelta a la lista de equipos sin realizar cambios
            NavigationService?.GoBack();
        }
    }
}
