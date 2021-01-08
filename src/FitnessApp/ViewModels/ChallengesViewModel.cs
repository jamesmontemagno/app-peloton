using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.ViewModels
{
    public class ChallengesViewModel : BaseViewModel
    {
        public ChallengesViewModel()
        {
            SelectCategoryCommand = new Command<string>(OnSelectCategory);
        }

        int selectedCategoryIndex;
        public int SelectedCategoryIndex
        {
            get => selectedCategoryIndex;
            set => SetProperty(ref selectedCategoryIndex, value);
        }

        public Command<string> SelectCategoryCommand { get; }

        void OnSelectCategory(string index)
        {
            if(int.TryParse(index, out int i))
            {
                SelectedCategoryIndex = i;
            }
        }
    }
}
