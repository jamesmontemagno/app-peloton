using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassesPage : ContentPage
    {
        public ClassesPage()
        {
            InitializeComponent();
        }

        private async void Collections_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((e.CurrentSelection?.Count() ?? 0) == 0)
                return;
            await Shell.Current.GoToAsync($"//MainTabs/{nameof(CollectionDetailPage)}");
            Collections.SelectedItem = null;
        }
    }
}