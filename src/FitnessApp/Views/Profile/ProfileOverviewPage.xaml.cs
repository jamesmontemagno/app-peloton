using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessApp.Views.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileOverviewPage : ContentPage
    {
        public List<string> Days { get; }
        public List<string> Week1 { get; }
        public ProfileOverviewPage()
        {
            InitializeComponent();
            Days = new List<string> { "M", "T", "W", "T", "F", "S", "S" };
            Week1 = new List<string> { "18", "19", "20", "21", "22", "23", "24" };
            BindingContext = this;
        }
    }
}