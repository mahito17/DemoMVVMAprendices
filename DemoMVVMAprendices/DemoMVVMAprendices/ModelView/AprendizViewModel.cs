namespace DemoMVVMAprendices.ModelView
{
    using DemoMVVMAprendices.Model;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    using Model.Services;

    public class AprendizViewModel : Notificable
    {
        private ObservableCollection<Aprendiz> aprendices;

        public ObservableCollection<Aprendiz> Aprendices
        {
            get { return aprendices; }
            set
            {
                if (aprendices == value)
                {
                    return;
                }
                aprendices = value;
                OnPropertyChanged();
            }
        }
        private bool isEnabled;

        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                if (isEnabled == value)
                {
                    return;
                }
                isEnabled = value;
                OnPropertyChanged();
            }
        }

        public Command CargarAprendizCommand { get; set; }


        public AprendizViewModel()
        {
            Aprendices = new ObservableCollection<Aprendiz>();
            CargarAprendizCommand = new Command((obj) => CargarAprendices());
        }

        private async void CargarAprendices()
        {
            if (!IsEnabled)
            {
                IsEnabled = true;
                await Task.Delay(3000);
                Data listAprendices = CaracterizacionAprendices.CargarAprendices();
                Aprendices = listAprendices.Aprendices;
                //Aprendices = CargarAprendiz();
                IsEnabled = false;

            }
        }

        private ObservableCollection<Aprendiz> CargarAprendiz()
        {
            var aprendices = new ObservableCollection<Aprendiz>();
            string[] nombres = { "Oscar", "Elkin", "Francisco", "Victor Manuel",
                                "Alejandro", "Dina", "Oliverio", "Mauricio", "Jesús"};
            string[] apellidos = { "Cárdenas", "Ortua", "Martínez", "López", "González" };
            string[] programas = { "Contabilidad y Finanzas", "Producción Multimedia", "ADSI", "Animación 3D", "Diseño Gráfico" };

            Random rdn = new Random();



            for (int i = 0; i < 20; i++)
            {
                Aprendiz aprendiz = new Aprendiz();
                aprendiz.Nombre = nombres[rdn.Next(0, 8)];
                aprendiz.Apellido = $"{apellidos[rdn.Next(0, 4)]}";
                double ficha = rdn.Next(1618618, 2000000);
                aprendiz.Ficha = ficha;
                aprendiz.Programa = programas[rdn.Next(0, 4)];
                aprendiz.Promedio = rdn.Next(100, 1000);

                aprendices.Add(aprendiz);

            }
            return aprendices;
        }
    }
}