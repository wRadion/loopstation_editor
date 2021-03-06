﻿using System.Linq;
using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings.Memory
{
    [XmlRoot("database")]
    public class MemoryFileModel : FileModel
    {
        public const string FileName = "MEMORY.RC0";
        public const int MemoryCount = 99;

        public static MemoryFileModel Load(string file) => Load<MemoryFileModel>(file);

        [XmlElement("mem")]
        public MemoryModel[] Memories { get; set; }

        public MemoryFileModel() : base()
        {
            Memories = new MemoryModel[MemoryCount];

            for (int i = 0; i < Memories.Length; ++i)
                Memories[i] = new MemoryModel(i);
        }

        public override void ApplyXmlValues() => Memories.ToList().ForEach((m) => m.ApplyXmlValues());
        public override void ApplyPropertyValues() => Memories.ToList().ForEach((m) => m.ApplyPropertyValues());
    }
}
