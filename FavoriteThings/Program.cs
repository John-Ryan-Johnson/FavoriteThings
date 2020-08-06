using System;


namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cars

            var car1 = new Cars("Chevy", "Chevelle")
            {
                IsCool = true
            };

            var car2 = new Cars("Nissan", "Versa")
            {
                IsCool = false
            };

            car1.SeeMechanic();
            car2.SeeMechanic();

            car1.Burnout("black-top");
            car2.Burnout("gravel");

            //Motorcycles

            var motorcycle1 = new Motorcycles("Fatboy", "Harley")
            {
                IsDirtBike = false
            };

            var motorcycle2 = new Motorcycles("Yamaha", "YZF-450")
            { 
                IsDirtBike = true
            };

            motorcycle1.MotoInfo();
            motorcycle2.MotoInfo();

            motorcycle1.OffOrOn();
            motorcycle2.OffOrOn();

            //Movies

            var movie1 = new Movies("First Blood", "Action");
            var movie2 = new Movies("Silence of the Lambs", "Thriller");

            movie1.Unwatched();
            movie2.Unwatched();

            movie1.Watched();
            movie2.Watched();


            //Pets

            var pet1 = new Pets("Mojo", "dog")
            {
                Age = 6,
                IsExcited = true
            };

            var pet2 = new Pets("Snowflake", "cat")
            {
                Age = 2,
                IsExcited = false
            };

            pet1.PetInfo();
            pet2.PetInfo();

            pet1.DadsHome();
            pet2.DadsHome();

            
        }
    }
}
