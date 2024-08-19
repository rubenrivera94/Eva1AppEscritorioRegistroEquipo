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

using Evaluacion1AppRegistroEquipoFootball.Models;

namespace Evaluacion1AppRegistroEquipoFootball
{
    public partial class AgregarEquipoPage : Page
    {
        public AgregarEquipoPage()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreEquipo.Text) ||
                string.IsNullOrWhiteSpace(txtCantidadJugadores.Text) ||
                string.IsNullOrWhiteSpace(txtNombreDT.Text) ||
                string.IsNullOrWhiteSpace(txtTipoEquipo.Text) ||
                string.IsNullOrWhiteSpace(txtCapitanEquipo.Text) ||
                !chkTieneSub21.IsChecked.HasValue)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Intentar convertir el valor del TextBox a un entero
            if (!int.TryParse(txtCantidadJugadores.Text, out int cantidadJugadores))
            {
                MessageBox.Show("La cantidad de jugadores debe ser un número entero.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Crear un nuevo equipo con los datos validados
            Equipo nuevoEquipo = new Equipo
            (
                txtNombreEquipo.Text,
                cantidadJugadores,  // Usar el valor convertido a int
                txtNombreDT.Text,
                txtTipoEquipo.Text,
                txtCapitanEquipo.Text,
                chkTieneSub21.IsChecked.Value ? true : false
            );

            // Agregar el nuevo equipo a la lista estática
            EquipoData.Equipos.Add(nuevoEquipo);

            // Confirmación de que el equipo ha sido agregado
            MessageBox.Show("Equipo agregado exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

            // Limpiar los campos del formulario
            txtNombreEquipo.Clear();
            txtCantidadJugadores.Clear();
            txtNombreDT.Clear();
            txtTipoEquipo.Clear();
            txtCapitanEquipo.Clear();
            chkTieneSub21.IsChecked = false;
        }
    }
}
