using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FitnessApp.ViewModels
{
    public class ViewModelBase : BaseViewModel
    {
        public bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null) =>
            SetProperty<T>(ref field, newValue, propertyName, null, null);
    }
}
