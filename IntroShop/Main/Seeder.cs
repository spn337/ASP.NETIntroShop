using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main
{
    public class Seeder
    {
        public static void Initial(DBContent content)
        {
            if (!content.Phones.Any())
            {
                content.AddRange(
                    new Phone
                    {
                        Name = "Samsung S10",
                        Img = "/img/samsung_galaxy_s10_6_128.jpg",
                        SizeScreen = "6.1 inches",
                        Memory = "128 Gb",
                        Camera = "12Mpx + 12Mpx + 16Mpx",
                        Price = 23000,
                        //Category = _phoneCategory.PhoneCategories.First()
                    },
                    new Phone
                    {
                        Name = "Nokia 3310",
                        Img = "/img/Nokia3310.jpg",
                        SizeScreen = "113×48×22 мм",
                        Memory = "8Mb",
                        Camera = "2Mpx",
                        Price = 700,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                    new Phone
                    {
                        Name = "Meizu X8",
                        Img = "/img/meizu_x8_6_128gb_black.png",
                        SizeScreen = "6.15 inches",
                        Memory = "128 Gb",
                        Camera = "12Mpx + 5Mpx",
                        Price = 3999,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                    new Phone
                    {
                        Name = "Nokia 7.2",
                        Img = "/img/nokia_7_2_4_64gb_silver.jpg",
                        SizeScreen = "6.3 inches",
                        Memory = "64 Gb",
                        Camera = "48Mpx + 8Mpx + 5Mpx",
                        Price = 6299,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy S9",
                        Img = "/img/samsung_galaxy_s9_64gb_black.jpg",
                        SizeScreen = "5.8 inches",
                        Memory = "64 Gb",
                        Camera = "12Mpx",
                        Price = 12599,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                    new Phone
                    {
                        Name = "Fly Life Compact",
                        Img = "/img/fly_life_compact_dark_blue.jpg",
                        SizeScreen = "4.95 inches",
                        Memory = "8 Gb",
                        Camera = "5Mpx",
                        Price = 939,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    });
                content.SaveChanges();
            }
            if (!content.CPUs.Any())
            {
                content.AddRange(
                    new CPU
                   {
                       Name = "AMD Ryzen 5 3600",
                       Img = "/img/amd_ryzen_5_3600.jpg",
                       Price = 5880,
                       ClockFrequency = 3600,
                       CoreNumber = 6,
                       ThreadNumber = 12,
                       //Category = _phoneCategory.PhoneCategories.First()
                   },
                    new CPU
                    {
                        Name = "Intel Core i5-9400F",
                        Img = "/img/intel_core_i5_9400f.jpg",
                        Price = 4315,
                        ClockFrequency = 2900,
                        CoreNumber = 6,
                        ThreadNumber = 6,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                    new CPU
                    {
                        Name = "AMD Ryzen 9 3900X",
                        Img = "/img/amd_ryzen_9_3900x_.jpg",
                        Price = 15213,
                        ClockFrequency = 3800,
                        CoreNumber = 12,
                        ThreadNumber = 24,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                    new CPU
                    {
                        Name = "AMD Bristol Ridge A6-9400",
                        Img = "/img/amd_ad9400agabbox.jpg",
                        Price = 1005,
                        ClockFrequency = 3500,
                        CoreNumber = 2,
                        ThreadNumber = 2,
                        //Category = _phoneCategory.PhoneCategories.Last()

                    },
                    new CPU
                    {
                        Name = "Intel Core i9-9900 3.1GHz",
                        Img = "/img/intel_core_i9_9900_bx80684i99900.jpg",
                        Price = 13990,
                        ClockFrequency = 3100,
                        CoreNumber = 8,
                        ThreadNumber = 16,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                     new CPU
                     {
                         Name = "Intel Core i9-9900 3.1GHz",
                         Img = "/img/intel_core_i3_9100.jpg",
                         Price = 4109,
                         ClockFrequency = 3600,
                         CoreNumber = 4,
                         ThreadNumber = 4,
                         //Category = _phoneCategory.PhoneCategories.Last()
                     },
                      new CPU
                      {
                          Name = "Intel Pentium Gold G5420",
                          Img = "/img/intel_pentium_g5420_bx80684g5420.jpg",
                          Price = 1699,
                          ClockFrequency = 3800,
                          CoreNumber = 2,
                          ThreadNumber = 4,
                          //Category = _phoneCategory.PhoneCategories.Last()
                      },
                      new CPU
                      {
                          Name = "Intel Core i7-8700K",
                          Img = "/img/intel_core_i7_8700K.jpg",
                          Price = 11629,
                          ClockFrequency = 3700,
                          CoreNumber = 6,
                          ThreadNumber = 12,
                          //Category = _phoneCategory.PhoneCategories.Last()
                      },
                       new CPU
                       {
                           Name = "AMD Ryzen Threadripper 1920X",
                           Img = "/img/amd_ryzen_threadripper_1920x.jpg",
                           Price = 5945,
                           ClockFrequency = 3500,
                           CoreNumber = 12,
                           ThreadNumber = 24,
                           //Category = _phoneCategory.PhoneCategories.Last()
                       },
                       new CPU
                       {
                           Name = "AMD Ryzen 3 3200G 3.6GHz",
                           Img = "/img/amd_yd3200c5fhbox.jpg",
                           Price = 2786,
                           ClockFrequency = 3600,
                           CoreNumber = 4,
                           ThreadNumber = 4,
                           //Category = _phoneCategory.PhoneCategories.Last()
                       });
                content.SaveChanges();
            }
            if (!content.GPUs.Any())
            {
                content.AddRange(
                    new GPU
                    {
                        Name = "MSI PCI-Ex GeForce GTX 1660",
                        Img = "/img/msi_gtx_1660.png",
                        Price = 5880,
                        MemorySize = 6,
                        MemoryFrequency = 3000,
                        CoreFrequency = 1830,
                        MemoryBusBit = 192,
                        //Category = _phoneCategory.PhoneCategories.First()
                    },
                    new GPU
                    {
                        Name = "Asus PCI-Ex Radeon R7 240",
                        Img = "/img/asus_radeon_r7240.jpg",
                        Price = 1752,
                        MemorySize = 2,
                        MemoryFrequency = 1500,
                        CoreFrequency = 780,
                        MemoryBusBit = 128,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                    new GPU
                    {
                        Name = "AFOX PCI-Ex GeForce G210 1GB",
                        Img = "/img/afox_g210_1gb_gddr3.jpg",
                        Price = 819,
                        MemorySize = 1,
                        MemoryFrequency = 1402,
                        CoreFrequency = 589,
                        MemoryBusBit = 64,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    },
                    new GPU
                    {
                        Name = "Sapphire PCI-Ex Radeon RX 550",
                        Img = "/img/sapphire_11268_16_20g.jpg",
                        Price = 2222,
                        MemorySize = 2,
                        MemoryFrequency = 6000,
                        CoreFrequency = 1071,
                        MemoryBusBit = 128,
                        //Category = _phoneCategory.PhoneCategories.Last()
                    }
                  );
                content.SaveChanges();
            }
        }
    }
}
