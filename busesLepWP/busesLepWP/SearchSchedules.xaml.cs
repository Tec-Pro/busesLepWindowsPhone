using BindingExampleApp.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace busesLep
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchSchedules : Page
    {
        public SearchSchedules()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        private void txtCiudadOrigen_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Debug.WriteLine("clic ciudad origen");
            //aca deberia obtener las ciudades
            List<Ciudad> ciudadesOrigen = new List<Ciudad>();
            ciudadesOrigen.Add(new Ciudad() { nombreCiudad = "Origen" });
            ciudadesOrigen.Add(new Ciudad() { nombreCiudad = "Cordoba" });
            ciudadesOrigen.Add(new Ciudad() { nombreCiudad = "Villa Maria" });
            //abro la otra gui
            Frame.Navigate(typeof(ListViewCiudades), ciudadesOrigen);


        }



        private void chkIdaVuelta_Toggled(object sender, RoutedEventArgs e)
        {
            if (contenedorFechaVuelta != null) {
                if (chkIdaVuelta.IsOn)
                    contenedorFechaVuelta.Visibility = Visibility.Visible;
                else
                    contenedorFechaVuelta.Visibility = Visibility.Collapsed;
            }
        }
    }
    }
