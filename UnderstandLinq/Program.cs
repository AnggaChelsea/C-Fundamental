namespace UndertandLinq
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Car> mycar = new List<Car>()
            {
                    new Car { VIN = "A1", Model = "Alfard", Year = "2022", Price = 4000},
                    new Car { VIN = "A1", Model = "Toyota", Year = "2023", Price = 5000 },
                    new Car { VIN = "A3", Model = "Toyota2", Year = "2021", Price = 6000 },
                    new Car { VIN = "A4", Model = "Toyota3", Year = "2020", Price = 7000 },

            };

            //linq query
            // var alfard = from car in mycar where car.VIN == "A1" && car.Year == "2024" select car; 


            //descanding
            //var descandingcar = from car in mycar orderby car.Year ascending select car;
            //linq method
            var descanding = mycar.OrderByDescending(x => x.Year).ToList();
            //var fortuner = mycar.Where(p => p.VIN == "A1" && p.Year == "2022 ").ToList();

            //get first in object
            var first = mycar .OrderByDescending(x => x.Year).First(p => p.Year == "2023");
            //Console.WriteLine(first.VIN);

            mycar.ForEach(p => Console.WriteLine(p.Price -= 1000));

            //mycar.ForEach(x => Console.WriteLine("{0} {C:1}", x.VIN, x.Price));
            /* foreach (var car in descanding)
            {
                Console.WriteLine("{0} {1} {2}", car.VIN, car.Model, car.Year);
            }
            */

        }
    }

    class Book
    {
        public string Name { get; set; }
        public string Title { get; set; }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public int Price { get; set; }
    }
}