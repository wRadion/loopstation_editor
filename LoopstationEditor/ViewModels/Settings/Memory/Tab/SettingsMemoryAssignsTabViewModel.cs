﻿using System;

using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory.Tab
{
    public class SettingsMemoryAssignsTabViewModel : SettingsContainerViewModel
    {
        public override SettingsViewModel CurrentViewModel
        {
            get
            {
                switch (SelectedIndex)
                {
                    case 0: return Assign1;
                    case 1: return Assign2;
                    case 2: return Assign3;
                    case 3: return Assign4;
                    case 4: return Assign5;
                    case 5: return Assign6;
                    case 6: return Assign7;
                    case 7: return Assign8;
                    case 8: return Assign9;
                    case 9: return Assign10;
                    case 10: return Assign11;
                    case 11: return Assign12;
                    case 12: return Assign13;
                    case 13: return Assign14;
                    case 14: return Assign15;
                    case 15: return Assign16;
                }

                throw new ArgumentOutOfRangeException("Assign index must be between 0 and 15.");
            }
        }

        public SettingsMemoryAssignViewModel Assign1 { get; }
        public SettingsMemoryAssignViewModel Assign2 { get; }
        public SettingsMemoryAssignViewModel Assign3 { get; }
        public SettingsMemoryAssignViewModel Assign4 { get; }
        public SettingsMemoryAssignViewModel Assign5 { get; }
        public SettingsMemoryAssignViewModel Assign6 { get; }
        public SettingsMemoryAssignViewModel Assign7 { get; }
        public SettingsMemoryAssignViewModel Assign8 { get; }
        public SettingsMemoryAssignViewModel Assign9 { get; }
        public SettingsMemoryAssignViewModel Assign10 { get; }
        public SettingsMemoryAssignViewModel Assign11 { get; }
        public SettingsMemoryAssignViewModel Assign12 { get; }
        public SettingsMemoryAssignViewModel Assign13 { get; }
        public SettingsMemoryAssignViewModel Assign14 { get; }
        public SettingsMemoryAssignViewModel Assign15 { get; }
        public SettingsMemoryAssignViewModel Assign16 { get; }

        public SettingsMemoryAssignsTabViewModel(MemoryModel model)
            : base(model)
        {
            Assign1 = new SettingsMemoryAssignViewModel(model.Assign1);
            Assign2 = new SettingsMemoryAssignViewModel(model.Assign2);
            Assign3 = new SettingsMemoryAssignViewModel(model.Assign3);
            Assign4 = new SettingsMemoryAssignViewModel(model.Assign4);
            Assign5 = new SettingsMemoryAssignViewModel(model.Assign5);
            Assign6 = new SettingsMemoryAssignViewModel(model.Assign6);
            Assign7 = new SettingsMemoryAssignViewModel(model.Assign7);
            Assign8 = new SettingsMemoryAssignViewModel(model.Assign8);
            Assign9 = new SettingsMemoryAssignViewModel(model.Assign9);
            Assign10 = new SettingsMemoryAssignViewModel(model.Assign10);
            Assign11 = new SettingsMemoryAssignViewModel(model.Assign11);
            Assign12 = new SettingsMemoryAssignViewModel(model.Assign12);
            Assign13 = new SettingsMemoryAssignViewModel(model.Assign13);
            Assign14 = new SettingsMemoryAssignViewModel(model.Assign14);
            Assign15 = new SettingsMemoryAssignViewModel(model.Assign15);
            Assign16 = new SettingsMemoryAssignViewModel(model.Assign16);
        }

        public override void ApplyChanges()
        {
            Assign1.ApplyChanges();
            Assign2.ApplyChanges();
            Assign3.ApplyChanges();
            Assign4.ApplyChanges();
            Assign5.ApplyChanges();
            Assign6.ApplyChanges();
            Assign7.ApplyChanges();
            Assign8.ApplyChanges();
            Assign9.ApplyChanges();
            Assign10.ApplyChanges();
            Assign11.ApplyChanges();
            Assign12.ApplyChanges();
            Assign13.ApplyChanges();
            Assign14.ApplyChanges();
            Assign15.ApplyChanges();
            Assign16.ApplyChanges();
        }

        public override void RevertChanges()
        {
            Assign1.RevertChanges();
            Assign2.RevertChanges();
            Assign3.RevertChanges();
            Assign4.RevertChanges();
            Assign5.RevertChanges();
            Assign6.RevertChanges();
            Assign7.RevertChanges();
            Assign8.RevertChanges();
            Assign9.RevertChanges();
            Assign10.RevertChanges();
            Assign11.RevertChanges();
            Assign12.RevertChanges();
            Assign13.RevertChanges();
            Assign14.RevertChanges();
            Assign15.RevertChanges();
            Assign16.RevertChanges();
        }
    }
}