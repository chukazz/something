namespace LR19LR18;
class Program
{
    

    public static bool Check(RacNumber a)
    {
        return a.M > a.N ? true : false;
    }

    public static void Main(string[] args)
    {
        // 1
        List<RacNumber> someList = new List<RacNumber>();
        List<RacNumber> racNumbers = new List<RacNumber>();
        racNumbers.Add(new RacNumber(1, 2));
        racNumbers.Add(new RacNumber(5, 4));
        racNumbers.Add(new RacNumber(7, 15));
        racNumbers.Add(new RacNumber(9, 11));
        racNumbers.Add(new RacNumber(2, 2));
        racNumbers.Add(new RacNumber(2, 4));


        for (int i = 0; i < racNumbers.Count; i++)
        {
            if (Check(racNumbers[i]) == true)
            {
                someList.Add(racNumbers[i]);
                racNumbers.RemoveAt(i);
            }
        }

        Console.WriteLine($"Количество элементов первого листа {racNumbers.Count} Второго {someList.Count}");
        someList.Sort();
        foreach (RacNumber racNumber in someList)
            racNumber.Print();


        // 2 


        CollectionType<SubjiectGuide> collection = new CollectionType<SubjiectGuide>();
        collection.Add(new SubjiectGuide("fdsff", new int[5]));
        collection.Add(new SubjiectGuide("fdsfff", new int[10]));
        collection.Add(new SubjiectGuide("fdsfjf", new int[15]));
        collection.RemoveAt(0);
        Console.WriteLine(collection.Count);


        // 3

        List<Worker<int>> workers = new List<Worker<int>>();
        workers.Add(new Programmer<int>("никита", 5));
        workers.Add(new Manager<int>("валера", 1));
        workers.Add(new Manager<int>("иван", 5));
        foreach(var abobus in workers)
            Console.WriteLine(abobus.ToString());

        // 4

        CustomStack<int> stack = new CustomStack<int>();
        stack.Push(6);
        stack.Push(1);
        stack.Push(9);
        stack.Push(5);
        Console.WriteLine(stack.Peek());


        // лр 19

        // 1
        string[] a = new string[] { "Falluot 3", "Daxter 2", "System Shok 2", "Morrowind", "Pes 201" };
        var data = a.Where(x => x.Contains(" "));
        foreach (var item in data)
            Console.Write(item + " ");
        

        // 2

        int[] b = new int[] { 2, -7, -10, 6, 7, 9, 3 };
        var dataTwo = b.Where(x => x < 0);
        foreach (var item in dataTwo)
            Console.Write(item + " ");
     


        // 3 

        string[] c = new string[] { "Light Green", "Red", "Green", "Yellow Purple",
            "Dark Green", "Light Red", "Dark Red", "Dark Yellow" , "Light Yellow"};
        var dataThree = c.Where(x => x.Contains("Green"));
        foreach (var item in dataThree)
            Console.WriteLine(item);
      


        // 4

        List<Car> cars = new List<Car>();
        cars.Add(new Car(100, "Red", 4, Marka.Bmw));
        cars.Add(new Car(120, "White", 6, Marka.Kia));
        cars.Add(new Car(90, "Black", 5, Marka.Hyndai));
        cars.Add(new Car(150, "Silver", 8, Marka.Bmw));

        var dataFour = cars.Where(x => x.Marka == Marka.Bmw);
        foreach (Car car in dataFour)
            car.Print();
   


        // 5

        List<Product> products = new List<Product>();
        products.Add(new Product("колла", 100, "вредное"));
        products.Add(new Product("чипсы", 4, "вредное"));
        products.Add(new Product("сигареты", 0, "вредное"));

        var dataFive = products.Where(x => x.CountOnStore == 0);
        foreach (var item in dataFive)
            item.Print();
    


        // 6

        List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
        List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
        var dataSix = myCars.Intersect(yourCars);
        foreach (string item in dataSix)
            Console.WriteLine(item);









    }
}