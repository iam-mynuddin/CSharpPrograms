using System.Runtime.Intrinsics.Arm;
using Collections;

public static class ListExample
{
    public static void Run()
    {
        List<int> intList=new(9);
        List<string> strList=new(9);
        intList.Add(8);
        intList.Add(9);
        intList.Add(8);
        intList.Add(9);
        intList.Remove(8);


        Car indica;

        indica.Company="Tata";
        indica.Color="Red";
        indica.ModelYear=2022;

        List<Car> listCars=new();
        listCars.Add(new Car{ Color="Green",Company="Lambo",ModelYear=2024});
        listCars.Add(new Car{ Color="Yellow",Company="Lambo",ModelYear=2014});

        Car car1=listCars[1];
        
        listCars.Remove(car1);
        foreach(Car car in listCars)
        {
            Console.WriteLine(car.Company+car.Color+car.ModelYear);

        }

        //Console.WriteLine(indica.Company+indica.Color+indica.ModelYear);

        // strList.Add("Hi");
        // MyPrinter.Print(strList);
        // MyPrinter.PrintWithLineNumber(intList);
        // MyPrinter.PrintSingle(intList);
    }
    public struct Car
    {
        public string Color;
        public int ModelYear;
        public string Company;

    }
}