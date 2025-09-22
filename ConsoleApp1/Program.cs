namespace ConsoleApp1;

internal class Program
{
    static Random random = new Random();
    static void Main(string[] args)
    {
        int num=0;
        try
        {
            num = WriteMenu();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return;
        }
        //if else if else
        //switch
        List<int> list = new List<int>();
        for (int i = 0; i < 10; i++) { 
            list.Add(random.Next(1,10));
        }
        switch (num)
        {
            case 1:Console.WriteLine(String.Join('\n',list)); break;
            case 2://char letter = Char.MinValue;
                //string word=letter.ToString()+letter.ToString();
                //Console.Write("kolbast" + word + "eedig tart");
                //Console.WriteLine(word.Length + " hosszu");
                Console.WriteLine("Add meg a szamot amit a listahoz akarsz adni!");
                Console.Write("Szam: ");
                int valueToAdd = CheckNum();
                list.Add(valueToAdd);
                break;
            case 3: Console.WriteLine("A legnagyobb szam: " + list.Max()); break;
            case 4: Console.WriteLine("A legkisebb szam: " + list.Min()); break;
            case 5:break;
            case 6:break;

        }
        Console.WriteLine($"A {num}. szamot valasztotta");
    }
    static int CheckNum() 
    {
        int chooseNumber = 0;
        if (int.TryParse(Console.ReadLine(), out chooseNumber))
        {
            return chooseNumber;
        }
        else {
            Console.WriteLine("Hibas Szam Megadasa");
            return default;
        }
    }
    static int WriteMenu()
    {
        Console.WriteLine("1. adatok listazasa");
        Console.WriteLine("2. adat letrehozasa");
        Console.WriteLine("3. legnagyobb adat");
        Console.WriteLine("4. legkisebb adat");
        Console.WriteLine("5. adat torlese");
        Console.WriteLine("6. kilepes");
        int chooseNumber = CheckNum();
        if (chooseNumber > 6 || 1 > chooseNumber)
        {

            throw new Exception("Helytelen szam");
        }
        return chooseNumber;

    }
}
