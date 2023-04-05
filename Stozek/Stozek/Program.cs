using mojStozek;

class Program
{
    static void Main(string[] args)
    {
        List<Bryla> listaBryl = new List<Bryla>();

        listaBryl.Add(new Stozek(5, 10));
        listaBryl.Add(new Stozek(3, 6));
        listaBryl.Add(new Czworoscian(2));
        listaBryl.Add(new Czworoscian(3));
        listaBryl.Add(new Czworoscian(4));

        foreach (Bryla bryla in listaBryl)
        {
            Console.WriteLine("Objetosc: " + bryla.Objetosc());
            Console.WriteLine("Pole Podstawy: "+  bryla.PolePodstawy());
            Console.WriteLine("Pole Boczne: " + bryla.PoleBoczne());
            Console.WriteLine("Pole Całkowite: " + bryla.PoleCalkowite());

            Console.WriteLine(" ");
        }
    }
}