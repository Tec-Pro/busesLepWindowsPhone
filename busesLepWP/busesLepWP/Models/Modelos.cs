using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Collections;

namespace BindingExampleApp.ViewModels
{

    //esta clase sirve para hacer el binding entre la gui y los datos, vendría a ser los datos logicos
    //que se muestran en un layoutItem de android, en este ejemplo Ciudad representa el layout que
    //tiene el nombre de la ciudad nada mas
    public class Ciudad
    {

        private string _nombreCiudad;

        public string nombreCiudad
        {
            get
            {
                return _nombreCiudad;
            }
            set
            {
                if (value != _nombreCiudad)
                {
                    _nombreCiudad = value;
                }
            }
        }
    }


        
    }





