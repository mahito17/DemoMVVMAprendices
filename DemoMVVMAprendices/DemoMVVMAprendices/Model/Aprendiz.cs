using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMVVMAprendices.Model
{
    public class Aprendiz : Notificable
    {
        private string nombre;
        private string apellido;
        private string programa;
        private double ficha;
        private double promedio;

        public double Promedio
        {
            get
            {
                return promedio;
            }
            set
            {
                if (promedio == value)
                {
                    return;
                }
                promedio = value;
                OnPropertyChanged();
            }
        }


        public double Ficha
        {
            get
            {
                return ficha;
            }
            set
            {
                if (ficha == value)
                {
                    return;
                }
                ficha = value;
                OnPropertyChanged();
            }
        }


        public string Programa
        {
            get
            {
                return programa;
            }
            set
            {
                if (programa == value)
                {
                    return;
                }
                programa = value;
                OnPropertyChanged();
            }
        }


        public string Apellido
        {

            get
            {
                return apellido;
            }
            set
            {
                if (apellido == value)
                {
                    return;
                }
                apellido = value;
                OnPropertyChanged();
            }
        }


        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();
            }
        }

    }
}