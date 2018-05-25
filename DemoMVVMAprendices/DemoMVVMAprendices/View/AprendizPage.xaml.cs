
namespace DemoMVVMAprendices
{
    using Xamarin.Forms;
    using ModelView;
    using Model;
    using View;
    public partial class AprendizPage : ContentPage
    {
        public AprendizPage()
        {
            InitializeComponent();
            this.BindingContext = new AprendizViewModel();
            lstName.ItemSelected += LstName_ItemSelected;

        }

        private void LstName_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var aprendizSeleccionado = (Aprendiz)e.SelectedItem;
            if (aprendizSeleccionado == null)
            {
                return;

            }
            Navigation.PushAsync(new DetalleApreniz(aprendizSeleccionado));
            lstName.SelectedItem = null;
        }
    }
}