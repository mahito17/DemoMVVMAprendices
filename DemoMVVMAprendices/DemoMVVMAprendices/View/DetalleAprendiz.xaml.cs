
namespace DemoMVVMAprendices.View
{
    using DemoMVVMAprendices.Model;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleApreniz : ContentPage
    {
        public DetalleApreniz(Aprendiz aprendizSeleccionado)
        {
            InitializeComponent();
            this.BindingContext = aprendizSeleccionado;
        }
    }
}