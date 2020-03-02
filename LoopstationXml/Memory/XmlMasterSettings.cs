﻿using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("MASTER")]
    public class XmlMasterSettings : ICloneable<XmlMasterSettings>
    {
        private int _level;
        private int _tempo;
        private int _compressor;
        private int _reverb;
        private int _phonesOut;
        private int _phonesOutTracks;

        [XmlElement("Lvl")]
        public int Level
        {
            get => _level;
            set => _level = Range.Guard(value);
        }

        [XmlElement("Tmp")]
        public int Tempo
        {
            get => _tempo;
            set => _tempo = Range.Guard(value, min: 400, max: 2500);
        }

        [XmlElement("Cs")]
        public int Compressor
        {
            get => _compressor;
            set => _compressor = Range.Guard(value, max: 40);
        }

        [XmlElement("Rv")]
        public int Reverb
        {
            get => _reverb;
            set => _reverb = Range.Guard(value);
        }

        [XmlElement("PhOut")]
        public int PhonesOut
        {
            get => _phonesOut;
            set => _phonesOut = Range.Guard(value, max: 1);
        }

        [XmlElement("PhOutTr")]
        public int PhonesOutTracks
        {
            get => _phonesOutTracks;
            set => _phonesOutTracks = Range.Guard(value, max: 31);
        }

        public XmlMasterSettings() : this(null) { }
        public XmlMasterSettings(XmlMasterSettings other)
        {
            Level = other?.Level ?? 50;
            Tempo = other?.Tempo ?? 1200;
            Compressor = other?.Compressor ?? 0;
            Reverb = other?.Reverb ?? 0;
            PhonesOut = other?.PhonesOut ?? 0;
            PhonesOutTracks = other?.PhonesOutTracks ?? 31;
        }

        public XmlMasterSettings Clone() => new XmlMasterSettings(this);
    }
}
