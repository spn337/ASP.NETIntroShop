using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class GPU
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public uint Price { get; set; }
        public uint MemorySize { get; set; }
        public uint MemoryFrequency { get; set; }
        public uint CoreFrequency { get; set; }
        public uint MemoryBusBit { get; set; }
    }
}
