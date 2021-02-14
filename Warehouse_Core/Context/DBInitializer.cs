using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Warehouse_Core.Models;

namespace Warehouse_Core.Context
{
    public static class DbInitializer
    {
        public static void Initialize(Warehouse_Core.Context.WarehouseContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any items in Storage
            if (context.Storages.Any())
            {
                return;   // DB has been seeded
            }


            //INFO
            //Add new migration
            //Update database
            //Delete everything from table and after that initialize and seed the data to DB


            //Calculate FullPrice in LaptopModels


            decimal? FullPrice(decimal? Price, int Quantity)
            {
                decimal? result = Price * Convert.ToDecimal(Quantity);
                return result;
            }


            //Calculate full price with PDV

            decimal PDV = 25;

            decimal? FullPriceWithPDV(decimal? Price, int Quantity)
            {
                decimal? result = Price * Convert.ToDecimal(Quantity);
                decimal? resultWithPDV = result * (PDV / 100) + result;
                return resultWithPDV;
            }


            //Calculate just PDV

            decimal? justPDV(decimal? Price, int Quantity)
            {
                decimal? result = Price * Convert.ToDecimal(Quantity);
                decimal? resultPDV = result * (PDV / 100);
                return resultPDV;
            }

            //Calculate Savings in LaptopModels

            decimal? Savings(decimal? OldPrice, decimal? Price)
            {
                decimal? result = OldPrice - Price;
                return result;
            }




            var storage = new Storage[]
            {
                new Storage { 
                   Name = "Notebook HP 250-G7",
                   Details = "UMA i3-8130U/15.6 FHD/8GB/256GB/W10H 7DC56EA",
                   Quantity = 100,
                   Manufacturer = "HP",
                   OS = "Windows 10",
                   Price = 4333,
                   OldPrice = 7754,
                   FullPrice = FullPrice(4333,100),
                   FullPriceWithPDV = FullPriceWithPDV(4333,100),
                   PDV = justPDV(4333,100),
                   Savings = Savings(7754,4333),
                   Date = DateTime.Now
                },
                 new Storage {
                   Name = "Notebook HP 250-G7-2",
                   Details = "UMA i3-8130U/15.6 FHD/8GB/256GB/W10H 7DC56EA",
                   Quantity = 100,
                   Manufacturer = "HP",
                   OS = "Windows 10",
                   Price = 4333,
                   OldPrice = 7754,
                   FullPrice = FullPrice(4333,100),
                   FullPriceWithPDV = FullPriceWithPDV(4333,100),
                   PDV = justPDV(4333,100),
                   Savings = Savings(7754,4333),
                   Date = DateTime.Now
                }
                //new Storage { FirstMidName = "Meredith", LastName = "Alonso",
                //    EnrollmentDate = DateTime.Parse("2018-09-01") },
                //new Storage { FirstMidName = "Arturo",   LastName = "Anand",
                //    EnrollmentDate = DateTime.Parse("2019-09-01") },
                //new Storage { FirstMidName = "Gytis",    LastName = "Barzdukas",
                //    EnrollmentDate = DateTime.Parse("2018-09-01") },
                //new Storage { FirstMidName = "Yan",      LastName = "Li",
                //    EnrollmentDate = DateTime.Parse("2018-09-01") },
                //new Storage { FirstMidName = "Peggy",    LastName = "Justice",
                //    EnrollmentDate = DateTime.Parse("2017-09-01") },
                //new Storage { FirstMidName = "Laura",    LastName = "Norman",
                //    EnrollmentDate = DateTime.Parse("2019-09-01") },
                //new Storage { FirstMidName = "Nino",     LastName = "Olivetto",
                //    EnrollmentDate = DateTime.Parse("2011-09-01") }
            };

            context.Storages.AddRange(storage);
            context.SaveChanges();

        }
    }
}
