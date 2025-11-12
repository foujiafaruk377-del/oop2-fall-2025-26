using System

public class House  //Class

{

    public int Yearbuilt { set; get; }

    public double Size { set; get; }

    public House(int yearbuilt, double size) //Constructor

    {

        Yearbuilt = yearbuilt;

        Size = size;

    }

    private int HowOld() //Properties

    {

        int currentYear = DateTime.Now.Year;

        return currentYear - Yearbuilt;

    }

    public bool CanBeSold()  //Properties

    {

        int age = HowOld();

        return age > 15;

    }

    public void ShowInfo()

    {

        Console.WriteLine();

        Console.WriteLine("---House Info---");

        Console.WriteLine($"Year Build: {Yearbuilt} and Size: {Size} sqft");

        Console.WriteLine($"Can be sold: {CanBeSold()}");

        Console.WriteLine();

    }

}

class Program

{

    public static void Main()

    {

        Console.Write("Enter the year build of your house: ");

        int yearbuilt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of your house: ");

        double size = Convert.ToDouble(Console.ReadLine());

        House house = new House(yearbuilt, size);

        house.ShowInfo();


    }

}





