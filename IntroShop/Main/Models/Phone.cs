using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SizeScreen { get; set; }
        public string Memory { get; set; }
        public string Camera { get; set; }
        public string Img { get; set; }
        public uint Price { get; set; }
    }
}
