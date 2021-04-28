using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFinder.Data
{
    public class ApplicationDbContextInit
    {
        public static void Initialize(ApplicationDbContext context)
        {
            SeedCars(context);
        }

        private static void SeedCars(ApplicationDbContext context)
        {
            if (context.Cars.Any())
            {
                return;
            }

            context.Cars.AddRange(
                     new Car
                     {
                         Model = "Corrolla",
                         Brand = "Toyota",
                         IsNew = false,
                         Color = "Yellow",
                         Mileage = 30000,
                     },
                    new Car
                    {
                        Model = "Model 3",
                        Brand = "Tesla",
                        IsNew = true,
                        Color = "White",
                        Mileage = 0,
                    },
                    new Car
                    {
                        Model = "Hilux",
                        Brand = "Toyota",
                        IsNew = false,
                        Color = "Black",
                        Mileage = 15000,
                    },
                    new Car
                    {
                        Model = "X5",
                        Brand = "BMW",
                        IsNew = false,
                        Color = "White",
                        Mileage = 20000,
                    },
                    new Car
                    {
                        Model = "V40",
                        Brand = "Volvo",
                        IsNew = false,
                        Color = "Grey",
                        Mileage = 8000,
                    },
                    new Car
                    {
                        Model = "Fiat",
                        Brand = "Punto",
                        IsNew = false,
                        Color = "White",
                        Mileage = 90000,
                    },
                    new Car
                    {
                        Model = "Tazz",
                        Brand = "Toyota",
                        IsNew = false,
                        Color = "Red",
                        Mileage = 14000,
                    },
                    new Car
                    {
                        Model = "GtR",
                        Brand = "Nissan",
                        IsNew = true,
                        Color = "black",
                        Mileage = 0,
                    },
                    new Car
                    {
                        Model = "Quantam",
                        Brand = "Toyota",
                        IsNew = false,
                        Color = "Green",
                        Mileage = 30000,
                    },
                    new Car
                    {

                        Model = "Venture",
                        Brand = "Toyota",
                        IsNew = false,
                        Color = "White",
                        Mileage = 95000,
                    },
                    new Car
                    {

                        Model = "Ghost",
                        Brand = "Rolls-Royce",
                        IsNew = true,
                        Color = "Black",
                        Mileage = 0,
                    },
                    new Car
                    {

                        Model = "P1",
                        Brand = "Mclaren",
                        IsNew = true,
                        Color = "Yellow",
                        Mileage = 0,
                    },
                    new Car
                    {
                        Model = "Veyron",
                        Brand = "Bugatti",
                        IsNew = true,
                        Color = "Blue",
                        Mileage = 0,
                    }
                );

            context.SaveChanges();
        }

    }
}
