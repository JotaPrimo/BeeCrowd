using BeeCrowd.Entities;


internal class Program
{
    private static void Main(string[] args)
    {
        // string[] Consumption = Console.ReadLine().Split(' ');

        int A = int.Parse(Console.ReadLine());       
        string B = Console.ReadLine();       

        Consumption consumption = new Consumption(A, B);     

        Console.WriteLine(consumption.calculeConsumption());      

    }


}