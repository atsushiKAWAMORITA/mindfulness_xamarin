using Xamarin.Forms;

namespace mindfulness
{
    public partial class mindfulnessPage : ContentPage
    {
        public mindfulnessPage()
        {
            InitializeComponent();
            this.BindingContext = new mindfulness.ViewModels.mindfulnessViewModel();
        }
    }
}
