using BindingExampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace busesLep
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListViewCiudades : Page
    {
        public ListViewCiudades()
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
            //Creo un tipo de ciudad para hacer el binding
            Ciudad CurrentViewModel = new Ciudad();
            //al datacontext le digo que los datos van a ser del tipo ciudad
            this.DataContext = CurrentViewModel;
            List<Ciudad> ciudades = e.Parameter as List<Ciudad>;
            if (ciudades.ElementAt(0).nombreCiudad == "Origen")
            {// si el primer elemento es origen, entonces estoy eligiendo ciudad de origen
                txtTitulo.Text = "Seleccione ciudad de ORIGEN";
            }
            else
            {
                txtTitulo.Text = "Seleccione ciudad de DESTINO";
            }
            ciudades.RemoveAt(0);
            this.LstVwCiudades.ItemsSource = e.Parameter as List<Ciudad>;
        }


    }


}
