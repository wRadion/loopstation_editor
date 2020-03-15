﻿using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public static class NameProperty
    {
        public const int Length = 12;

        public const string Character01 = "C01";
        public const string Character02 = "C02";
        public const string Character03 = "C03";
        public const string Character04 = "C04";
        public const string Character05 = "C05";
        public const string Character06 = "C06";
        public const string Character07 = "C07";
        public const string Character08 = "C08";
        public const string Character09 = "C09";
        public const string Character10 = "C10";
        public const string Character11 = "C11";
        public const string Character12 = "C12";
    }

    public class SettingsMemoryNameModel : SettingsModel
    {
        [XmlElement(NameProperty.Character01, typeof(int))]
        [Property('I', 32, 126)]
        public ValueChar Character01 { get; set; }

        [XmlElement(NameProperty.Character02, typeof(int))]
        [Property('N', 32, 126)]
        public ValueChar Character02 { get; set; }

        [XmlElement(NameProperty.Character03, typeof(int))]
        [Property('I', 32, 126)]
        public ValueChar Character03 { get; set; }

        [XmlElement(NameProperty.Character04, typeof(int))]
        [Property('T', 32, 126)]
        public ValueChar Character04 { get; set; }

        [XmlElement(NameProperty.Character05, typeof(int))]
        [Property(' ', 32, 126)]
        public ValueChar Character05 { get; set; }

        [XmlElement(NameProperty.Character06, typeof(int))]
        [Property('M', 32, 126)]
        public ValueChar Character06 { get; set; }

        [XmlElement(NameProperty.Character07, typeof(int))]
        [Property('E', 32, 126)]
        public ValueChar Character07 { get; set; }

        [XmlElement(NameProperty.Character08, typeof(int))]
        [Property('M', 32, 126)]
        public ValueChar Character08 { get; set; }

        [XmlElement(NameProperty.Character09, typeof(int))]
        [Property('O', 32, 126)]
        public ValueChar Character09 { get; set; }

        [XmlElement(NameProperty.Character10, typeof(int))]
        [Property('R', 32, 126)]
        public ValueChar Character10 { get; set; }

        [XmlElement(NameProperty.Character11, typeof(int))]
        [Property('Y', 32, 126)]
        public ValueChar Character11 { get; set; }

        [XmlElement(NameProperty.Character12, typeof(int))]
        [Property(' ', 32, 126)]
        public ValueChar Character12 { get; set; }

        public string Name
        {
            get => new string(new char[12]{ Character01, Character02, Character03, Character04,
                Character05, Character06, Character07, Character08,
                Character09, Character10, Character11, Character12 });

            set
            {
                Character01 = value[0]; Character02 = value[1]; Character03 = value[2]; Character04 = value[3];
                Character05 = value[4]; Character06 = value[5]; Character07 = value[6]; Character08 = value[7];
                Character09 = value[8]; Character10 = value[9]; Character11 = value[10]; Character12 = value[11];
            }
        }

        public SettingsMemoryNameModel() : base() { }
    }
}