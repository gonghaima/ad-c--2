namespace ClubMembershipApplication;


class Program
{
    static void Main(string[] args)
    {
        CommonOutputText.WriteLoginHeading();
        Console.WriteLine("Please press 'l' to login or if you are not yet registered please press 'r'");
        ConsoleKey key = Console.ReadKey().Key;
    }
}

