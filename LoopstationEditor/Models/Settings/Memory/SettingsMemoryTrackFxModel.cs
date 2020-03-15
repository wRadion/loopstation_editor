﻿using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum SingleTrackFx { FILTER = 0, PHASER = 1, FLANGER = 2, SYNTH = 3, LO_FI = 4, RING_MODULATOR = 5, GUITAR_TO_BASS = 6, SLOW_GEAR = 7, TRANSPOSE = 8, PITCH_BEND = 9, ROBOT = 10, VOCAL_DIST = 11, VOCODER = 12, DYNAMICS = 13, EQ = 14, ISOLATOR = 15, OCTAVE = 16, PAN = 17, TREMOLO = 18, SLICER = 19, DELAY = 20, PANNING_DELAY = 21, TAPE_ECHO = 22, GRANULAR_DELAY = 23, ROLL = 24, CHORUS = 25, REVERB = 26, BEAT_REPEAT = 27, BEAT_SHIFT = 28, BEAT_SCATTER = 29, VINYL_FLICK = 30 }
    public enum MultiTrackFxA { FILTER = 0, PHASER = 1, SYNTH = 2, LO_FI = 3, RING_MODULATOR = 4, GUITAR_TO_BASS = 5, SLOW_GEAR = 6, TRANSPOSE = 7, PITCH_BEND = 8, ROBOT = 9, VOCAL_DIST = 10, VOCODER = 11, DYNAMICS = 12, EQ = 13, ISOLATOR = 14, OCTAVE = 15, PAN = 16, TREMOLO = 17, SLICER = 18, BEAT_REPEAT = 19, BEAT_SHIFT = 20, BEAT_SCATTER = 21, VINYL_FLICK = 22 }
    public enum MultiTrackFxB { FILTER = 0, PHASER = 1, FLANGER = 2, LO_FI = 3, RING_MODULATOR = 4, VOCAL_DIST = 5, EQ = 6, ISOLATOR = 7, PAN = 8, TREMOLO = 9, SLICER = 10, DELAY = 11, PANNING_DELAY = 12, ROLL = 13, CHORUS = 14 }
    public enum MultiTrackFxC { FILTER = 0, PHASER = 1, FLANGER = 2, LO_FI = 3, RING_MODULATOR = 4, VOCAL_DIST = 5, EQ = 6, ISOLATOR = 7, PAN = 8, TREMOLO = 9, SLICER = 10, DELAY = 11, PANNING_DELAY = 12, TAPE_ECHO = 13, GRANUAR_DELAY = 14, ROLL = 15, CHORUS = 16, REVERB = 17 }

    public static class TrackFxProperty
    {
        public const string Mode = "Mod";
        public const string MultiMode = "MltMod";
        public const string SingleEnabledFxSlot = "Sw";
        public const string SelectedFxSlot = "Sel";
        public const string SelectedSingleFxA = "Typ1";
        public const string SelectedSingleFxB = "Typ2";
        public const string SelectedSingleFxC = "Typ3";
        public const string MultiEnabledFxSlot = "MltSw";
        public const string SelectedMultiFxA = "MltTyp1";
        public const string SelectedMultiFxB = "MltTyp2";
        public const string SelectedMultiFxC = "MltTyp3";
    }

    public class SettingsMemoryTrackFxModel : SettingsModel
    {
        [XmlElement(TrackFxProperty.Mode, typeof(int))]
        [Property(FxMode.SINGLE, 0, 1)]
        public ValueEnum<FxMode> Mode { get; set; }

        [XmlElement(TrackFxProperty.MultiMode, typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool MultiMode { get; set; }

        [XmlElement(TrackFxProperty.SingleEnabledFxSlot, typeof(int))]
        [Property(FxSlotOrNone.NONE, 0, 3)]
        public ValueEnum<FxSlotOrNone> SingleEnabledFxSlot { get; set; }

        [XmlElement(TrackFxProperty.SelectedFxSlot, typeof(int))]
        [Property(FxSlot.A, 0, 2)]
        public ValueEnum<FxSlot> SelectedFxSlot { get; set; }

        [XmlElement(TrackFxProperty.SelectedSingleFxA, typeof(int))]
        [Property(SingleTrackFx.FILTER, 0, 26)]
        public ValueEnum<SingleTrackFx> SelectedSingleFxA { get; set; }

        [XmlElement(TrackFxProperty.SelectedSingleFxB, typeof(int))]
        [Property(SingleTrackFx.LO_FI, 0, 26)]
        public ValueEnum<SingleTrackFx> SelectedSingleFxB { get; set; }

        [XmlElement(TrackFxProperty.SelectedSingleFxC, typeof(int))]
        [Property(SingleTrackFx.PAN, 0, 26)]
        public ValueEnum<SingleTrackFx> SelectedSingleFxC { get; set; }

        [XmlElement(TrackFxProperty.MultiEnabledFxSlot, typeof(int))]
        [Property(FxSlotBitwise.NONE, 0, 7)]
        public ValueEnum<FxSlotBitwise> MultiEnabledFxSlot { get; set; }

        [XmlElement(TrackFxProperty.SelectedMultiFxA, typeof(int))]
        [Property(MultiTrackFxA.FILTER, 0, 18)]
        public ValueEnum<MultiTrackFxA> SelectedMultiFxA { get; set; }

        [XmlElement(TrackFxProperty.SelectedMultiFxB, typeof(int))]
        [Property(MultiTrackFxB.LO_FI, 0, 14)]
        public ValueEnum<MultiTrackFxB> SelectedMultiFxB { get; set; }

        [XmlElement(TrackFxProperty.SelectedMultiFxC, typeof(int))]
        [Property(MultiTrackFxC.PAN, 0, 17)]
        public ValueEnum<MultiTrackFxC> SelectedMultiFxC { get; set; }

        public SettingsMemoryTrackFxModel() : base() { }
    }
}