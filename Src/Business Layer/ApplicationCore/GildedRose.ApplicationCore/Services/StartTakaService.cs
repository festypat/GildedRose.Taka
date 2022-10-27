using GildedRose.Data.Domain;
using GildedRose.Helper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ApplicationCore.Services
{
    public class StartTakaService
    {
        public static void LoadData()
        {
            ProcessItems();
        }
        public static void ProcessItems()
        {
            var data = ProductService.GetItems();

            if (data.Count > 0)
                data.UpdateItemQuality();
        }
    }
}
