﻿using System.Xml.Serialization;

using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.Models.Settings.System
{
    [XmlRoot("sys")]
    public class SystemModel : SettingsContainerModel
    {
        [XmlElement("SETUP")]
        public SettingsSystemSetupModel Setup { get; set; }

        [XmlElement("INPUT_OUTPUT")]
        public SettingsSystemInputOutputModel InputOutput { get; set; }

        [XmlElement("USB")]
        public SettingsSystemUSBModel USB { get; set; }

        [XmlElement("MIDI")]
        public SettingsSystemMIDIModel MIDI { get; set; }

        #region DefaultMemory
        #region Tracks
        [XmlElement("TRACK1")]
        public SettingsMemoryTrackModel Track1 { get; set; }
        [XmlElement("TRACK2")]
        public SettingsMemoryTrackModel Track2 { get; set; }
        [XmlElement("TRACK3")]
        public SettingsMemoryTrackModel Track3 { get; set; }
        [XmlElement("TRACK4")]
        public SettingsMemoryTrackModel Track4 { get; set; }
        [XmlElement("TRACK5")]
        public SettingsMemoryTrackModel Track5 { get; set; }
        #endregion Tracks

        [XmlElement("RHYTHM")]
        public SettingsMemoryRhythmModel Rhythm { get; set; }
        [XmlElement("NAME")]
        public SettingsMemoryNameModel Name { get; set; }
        [XmlElement("MASTER")]
        public SettingsMemoryMasterModel Master { get; set; }
        [XmlElement("REC_OPTION")]
        public SettingsMemoryRecOptionModel RecOption { get; set; }
        [XmlElement("PLAY_OPTION")]
        public SettingsMemoryPlayOptionModel PlayOption { get; set; }

        #region Assigns
        [XmlElement("ASSIGN1")]
        public SettingsMemoryAssignModel Assign1 { get; set; }
        [XmlElement("ASSIGN2")]
        public SettingsMemoryAssignModel Assign2 { get; set; }
        [XmlElement("ASSIGN3")]
        public SettingsMemoryAssignModel Assign3 { get; set; }
        [XmlElement("ASSIGN4")]
        public SettingsMemoryAssignModel Assign4 { get; set; }
        [XmlElement("ASSIGN5")]
        public SettingsMemoryAssignModel Assign5 { get; set; }
        [XmlElement("ASSIGN6")]
        public SettingsMemoryAssignModel Assign6 { get; set; }
        [XmlElement("ASSIGN7")]
        public SettingsMemoryAssignModel Assign7 { get; set; }
        [XmlElement("ASSIGN8")]
        public SettingsMemoryAssignModel Assign8 { get; set; }
        [XmlElement("ASSIGN9")]
        public SettingsMemoryAssignModel Assign9 { get; set; }
        [XmlElement("ASSIGN10")]
        public SettingsMemoryAssignModel Assign10 { get; set; }
        [XmlElement("ASSIGN11")]
        public SettingsMemoryAssignModel Assign11 { get; set; }
        [XmlElement("ASSIGN12")]
        public SettingsMemoryAssignModel Assign12 { get; set; }
        [XmlElement("ASSIGN13")]
        public SettingsMemoryAssignModel Assign13 { get; set; }
        [XmlElement("ASSIGN14")]
        public SettingsMemoryAssignModel Assign14 { get; set; }
        [XmlElement("ASSIGN15")]
        public SettingsMemoryAssignModel Assign15 { get; set; }
        [XmlElement("ASSIGN16")]
        public SettingsMemoryAssignModel Assign16 { get; set; }
        #endregion Assigns

        [XmlElement("INPUT_FX")]
        public SettingsMemoryInputFxModel InputFx { get; set; }
        [XmlElement("TRACK_FX")]
        public SettingsMemoryTrackFxModel TrackFx { get; set; }

        [XmlElement("BEAT_FX1")]
        public SettingsMemoryBeatFxModel BeatFxA { get; set; }
        [XmlElement("BEAT_FX2")]
        public SettingsMemoryBeatFxModel BeatFxB { get; set; }
        [XmlElement("BEAT_FX3")]
        public SettingsMemoryBeatFxModel BeatFxC { get; set; }

        [XmlElement("INPUT_FX1")]
        public SettingsMemoryFxModel InputFxA { get; set; }
        [XmlElement("INPUT_FX2")]
        public SettingsMemoryFxModel InputFxB { get; set; }
        [XmlElement("INPUT_FX3")]
        public SettingsMemoryFxModel InputFxC { get; set; }

        [XmlElement("TRACK_FX1")]
        public SettingsMemoryFxModel TrackFxA { get; set; }
        [XmlElement("TRACK_FX2")]
        public SettingsMemoryFxModel TrackFxB { get; set; }
        [XmlElement("TRACK_FX3")]
        public SettingsMemoryFxModel TrackFxC { get; set; }
        #endregion DefaultMemory

        public SystemModel() : base()
        {
            Setup = new SettingsSystemSetupModel();
            InputOutput = new SettingsSystemInputOutputModel();
            USB = new SettingsSystemUSBModel();
            MIDI = new SettingsSystemMIDIModel();

            #region DefaultMemory
            Track1 = new SettingsMemoryTrackModel();
            Track2 = new SettingsMemoryTrackModel();
            Track3 = new SettingsMemoryTrackModel();
            Track4 = new SettingsMemoryTrackModel();
            Track5 = new SettingsMemoryTrackModel();

            Rhythm = new SettingsMemoryRhythmModel();
            Name = new SettingsMemoryNameModel();
            Master = new SettingsMemoryMasterModel();
            RecOption = new SettingsMemoryRecOptionModel();
            PlayOption = new SettingsMemoryPlayOptionModel();

            Assign1 = new SettingsMemoryAssignModel();
            Assign2 = new SettingsMemoryAssignModel();
            Assign3 = new SettingsMemoryAssignModel();
            Assign4 = new SettingsMemoryAssignModel();
            Assign5 = new SettingsMemoryAssignModel();
            Assign6 = new SettingsMemoryAssignModel();
            Assign7 = new SettingsMemoryAssignModel();
            Assign8 = new SettingsMemoryAssignModel();
            Assign9 = new SettingsMemoryAssignModel();
            Assign10 = new SettingsMemoryAssignModel();
            Assign11 = new SettingsMemoryAssignModel();
            Assign12 = new SettingsMemoryAssignModel();
            Assign13 = new SettingsMemoryAssignModel();
            Assign14 = new SettingsMemoryAssignModel();
            Assign15 = new SettingsMemoryAssignModel();
            Assign16 = new SettingsMemoryAssignModel();

            InputFx = new SettingsMemoryInputFxModel();
            TrackFx = new SettingsMemoryTrackFxModel();

            BeatFxA = new SettingsMemoryBeatFxModel();
            BeatFxB = new SettingsMemoryBeatFxModel();
            BeatFxC = new SettingsMemoryBeatFxModel();

            InputFxA = new SettingsMemoryFxModel();
            InputFxB = new SettingsMemoryFxModel();
            InputFxC = new SettingsMemoryFxModel();

            TrackFxA = new SettingsMemoryFxModel();
            TrackFxB = new SettingsMemoryFxModel();
            TrackFxC = new SettingsMemoryFxModel();
            #endregion DefaultMemory
        }
    }
}
