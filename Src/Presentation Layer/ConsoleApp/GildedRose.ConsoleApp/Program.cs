// See https://aka.ms/new-console-template for more information
using GildedRose.ConsoleApp.Service;

Console.WriteLine("Hello, World!");

var startService = new ProductItemService();
startService.InitiateTakaService();