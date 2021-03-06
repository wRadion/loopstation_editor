﻿using System.ComponentModel;
using PropertyChanged;

namespace LoopstationEditor.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
