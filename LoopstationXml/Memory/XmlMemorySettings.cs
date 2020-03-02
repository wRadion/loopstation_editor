﻿using System.Xml.Serialization;

using Loopstation.Common;
using Loopstation.Xml.Base;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("mem")]
    public class XmlMemorySettings : XmlMemorySettingsBase, ICloneable<XmlMemorySettings>
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        public XmlMemorySettings() : this(null) { }
        public XmlMemorySettings(XmlMemorySettings other) : base(other) { }

        public XmlMemorySettings Clone() => new XmlMemorySettings(this);
    }
}
