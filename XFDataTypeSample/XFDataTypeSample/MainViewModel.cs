using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace XFDataTypeSample
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        string display;

        int count;
        [RelayCommand]
        void Increase()
        {
            count++;
            Display = $"Count: {count}";
        }
    }
}
