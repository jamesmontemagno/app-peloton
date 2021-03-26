using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using FitnessApp.Helpers;

namespace FitnessApp.ViewModels
{
    public class ProfileOverviewViewModel : ViewModelBase
    {
        public List<string> Days { get; }
        public List<string> Week1 { get; }
        public List<string> Week2 { get; }
        public List<string> Week3 { get; }
        public List<string> Week4 { get; }
        public List<string> Week5 { get; }
        public ProfileOverviewViewModel()
        {
            Days = new List<string> { "M", "T", "W", "T", "F", "S", "S" };
            Week1 = new List<string> { "22", "23", "24", "25", "26", "27", "28" };
            Week2 = new List<string> { "1", "2", "3", "4", "5", "6", "7" };
            Week3 = new List<string> { "8", "9", "10", "11", "12", "13", "14" };
            Week4 = new List<string> { "15", "16", "17", "18", "19", "20", "21" };
            Week5 = new List<string> { "22", "23", "24", "25", "26", "27", "28" };
            CompletedWeeks = new List<string> { FAIcons.CheckCircle, FAIcons.CheckCircle, FAIcons.CheckCircle, FAIcons.CheckCircle, FAIcons.CheckCircle };
            OnPropertyChanged(nameof(Days));
        }

        

        private List<string> completedWeeks;

        public List<string> CompletedWeeks 
        { 
            get => completedWeeks; 
            set => SetProperty(ref completedWeeks, value); 
        }
    }
}
