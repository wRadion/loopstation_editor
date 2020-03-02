﻿using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("PLAY_OPTION")]
    public class XmlPlayOptionSettings : ICloneable<XmlPlayOptionSettings>
    {
        private int _singlePlayChange;
        private int _loopQuantize;
        private int _loopMode;
        private int _loopLength;
        private int _allStart;
        private int _allStop;
        private int _fadeTime;
        private int _targetTrack;

        [XmlElement("SinglePlyChg")]
        public int SinglePlayChange
        {
            get => _singlePlayChange;
            set => _singlePlayChange = Range.Guard(value, max: 1);
        }


        [XmlElement("LpQtz")]
        public int LoopQuantize
        {
            get => _loopQuantize;
            set => _loopQuantize = Range.Guard(value, max: 2);
        }

        [XmlElement("LpMod")]
        public int LoopMode
        {
            get => _loopMode;
            set => _loopMode = Range.Guard(value, max: 1);
        }

        [XmlElement("LpLen")]
        public int LoopLength
        {
            get => _loopLength;
            set => _loopLength = Range.Guard(value, max: 1000);
        }

        [XmlElement("AllStrt")]
        public int AllStart
        {
            get => _allStart;
            set => _allStart = Range.Guard(value, max: 31);
        }

        [XmlElement("AllStp")]
        public int AllStop
        {
            get => _allStop;
            set => _allStop = Range.Guard(value, max: 31);
        }

        [XmlElement("FadeTim")]
        public int FadeTime
        {
            get => _fadeTime;
            set => _fadeTime = Range.Guard(value, min: 1, max: 64);
        }

        [XmlElement("TgtTr")]
        public int TargetTrack
        {
            get => _targetTrack;
            set => _targetTrack = Range.Guard(value, max: 4);
        }

        public XmlPlayOptionSettings() : this(null) { }
        public XmlPlayOptionSettings(XmlPlayOptionSettings other)
        {
            SinglePlayChange = other?.SinglePlayChange ?? 0;
            LoopQuantize = other?.LoopQuantize ?? 0;
            LoopMode = other?.LoopMode ?? 0;
            LoopLength = other?.LoopLength ?? 0;
            AllStart = other?.AllStart ?? 31;
            AllStop = other?.AllStop ?? 31;
            FadeTime = other?.FadeTime ?? 2;
            TargetTrack = other?.TargetTrack ?? 0;
        }

        public XmlPlayOptionSettings Clone() => new XmlPlayOptionSettings(this);
    }
}
