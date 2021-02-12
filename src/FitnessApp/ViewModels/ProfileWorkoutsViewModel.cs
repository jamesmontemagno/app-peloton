using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.ViewModels
{
    public class ProfileWorkoutsViewModel : BaseViewModel
    {

        public AsyncCommand WorkoutOptionsCommand { get; }
        public ProfileWorkoutsViewModel()
        {
            WorkoutOptionsCommand = new AsyncCommand(WorkoutOptions);
        }

        async Task WorkoutOptions()
        {
            await App.Current.MainPage.DisplayActionSheet("", "Cancel", "Delete Workout", "View Class Details", "Share Workout");
        }
    }
}
