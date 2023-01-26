namespace test
{
    public class Program
    {
        static void Main()
        {
            //Car car1= new Car();
            //car1.colour = "red";
            //car1.name = "BMW";
            //car1.horsePower = 123;
            //car1.highspeed = 324;
            //Console.WriteLine(car1.GetDetails());




            Animal Animal1 = new Animal("dog", "terrier", 4);
         
            Console.WriteLine(Animal1.GetDetails());

            Building Building1= new Building("happy homes",200,600);
            Console.WriteLine(Building1.Volume());




            Console.WriteLine(Building1.GetDetails());
            //Console.WriteLine(Building2.GetDetails());
        }
       

        

    }








}