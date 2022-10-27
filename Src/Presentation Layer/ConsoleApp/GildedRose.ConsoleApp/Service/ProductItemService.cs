using GildedRose.ApplicationCore.Services;
using GildedRose.Helper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ConsoleApp.Service
{
    public class ProductItemService
    {
        public void InitiateTakaService()
        {
            StartTakaService.ProcessItems();
        }
    }
}
