using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class CPU
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public uint Price { get; set; }
        public uint ClockFrequency {get;set; }
        public uint CoreNumber {get;set; }
        public uint ThreadNumber {get;set; }
    }
}
