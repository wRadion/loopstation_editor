﻿using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.System;

namespace LoopstationEditor.ViewModels
{
    public class ScreenText : ViewModel
    {
        public string TextLine1 { get; set; }
        public string TextLine2 { get; set; }

        public ScreenText() : this(string.Empty, string.Empty) { }
        public ScreenText(string line1) : this(line1, string.Empty) { }
        public ScreenText(string line1, string line2)
        {
            TextLine1 = line1;
            TextLine2 = line2;
        }
    }

    public class LoopstationViewModel : ViewModel
    {
        private SystemWindowViewModel _systemViewModel;
        private MemoryWindowViewModel[] _memoryViewModels;
        private int _currentMemoryIndex;

        public MemoryWindowViewModel CurrentMemory => _memoryViewModels[_currentMemoryIndex];

        public ScreenText ScreenText { get; private set; }

        public ICommand OpenSystemWindowSetupTab { get; }
        public ICommand OpenSystemWindowInputOutputTab { get; }
        public ICommand OpenSystemWindowUSBTab { get; }
        public ICommand OpenSystemWindowMIDITab { get; }

        public ICommand OpenMemoryWindowTracksTab { get; }
        public ICommand OpenMemoryWindowRhythmTab { get; }
        public ICommand OpenMemoryWindowNameTab { get; }
        public ICommand OpenMemoryWindowMasterTab { get; }
        public ICommand OpenMemoryWindowRecOptionTab { get; }
        public ICommand OpenMemoryWindowPlayOptionTab { get; }
        public ICommand OpenMemoryWindowAssignsTab { get; }
        public ICommand OpenMemoryWindowInputFxTab { get; }
        public ICommand OpenMemoryWindowTrackFxTab { get; }

        public LoopstationViewModel()
        {
            _systemViewModel = new SystemWindowViewModel(new SystemModel());
            _memoryViewModels = new MemoryWindowViewModel[MemoryFileModel.MemoryCount];

            ScreenText = new ScreenText();

            for (int i = 0; i < _memoryViewModels.Length; ++i)
                _memoryViewModels[i] = new MemoryWindowViewModel(new MemoryModel(i));
            SetMemory(0);

            // System
            OpenSystemWindowSetupTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.SETUP));
            OpenSystemWindowInputOutputTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.INPUT_OUTPUT));
            OpenSystemWindowUSBTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.USB));
            OpenSystemWindowMIDITab = new RelayCommand(() => _systemViewModel.Show(SystemTab.MIDI));

            // Memory
            OpenMemoryWindowTracksTab = new IntCommand((track) => CurrentMemory.ShowSubtab(MemoryTab.TRACKS, track - 1));
            OpenMemoryWindowRhythmTab = new RelayCommand(() => CurrentMemory.Show(MemoryTab.RHYTHM));
            OpenMemoryWindowNameTab = new RelayCommand(() => CurrentMemory.Show(MemoryTab.NAME));
            OpenMemoryWindowMasterTab = new RelayCommand(() => CurrentMemory.Show(MemoryTab.MASTER));
            OpenMemoryWindowRecOptionTab = new RelayCommand(() => CurrentMemory.Show(MemoryTab.REC_OPTION));
            OpenMemoryWindowPlayOptionTab = new RelayCommand(() => CurrentMemory.Show(MemoryTab.PLAY_OPTION));
            OpenMemoryWindowAssignsTab = new IntCommand((assign) => CurrentMemory.ShowSubtab(MemoryTab.ASSIGNS, assign - 1));
            OpenMemoryWindowInputFxTab = new RelayCommand(() => CurrentMemory.Show(MemoryTab.INPUT_FX));
            OpenMemoryWindowTrackFxTab = new RelayCommand(() => CurrentMemory.Show(MemoryTab.TRACK_FX));
        }

        public void SetMemory(int id)
        {
            _currentMemoryIndex = id;
            CurrentMemory.NameViewModelInitialized += CurrentMemory_NameViewModelInitialized;
            NameChanged(CurrentMemory.NameViewModel, new PropertyChangedEventArgs("Name"));
        }

        private void CurrentMemory_NameViewModelInitialized(SettingsMemoryNameViewModel viewModel)
        {
            viewModel.PropertyChanged += NameChanged;
        }

        private void NameChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Name") return;

            ScreenText.TextLine1 = $"{ CurrentMemory.Id.ToString("D2") }  { CurrentMemory.NameViewModel.Name }";
        }
    }
}
