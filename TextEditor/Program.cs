Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1- Open File");
    Console.WriteLine("2- Create new file");
    Console.WriteLine("0- Closed");
    short option = short.Parse(Console.ReadLine());

    switch(option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Closed(); break;
    }
}

static void Open()
{
    Console.Clear();
    Console.WriteLine("What is the file path?");
    string path = Console.ReadLine();

    using(var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }
    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}

static void Closed()
{
    Console.Clear();
    Console.WriteLine("Enter your text below: (ESC Closed) ");
    Console.WriteLine("__________________");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(text);

}

static void Save(string text)
{
    Console.Clear() ;
    Console.WriteLine("What path to save the file?");
    var path = Console.ReadLine();

    using (var file = new StreamWriter(path))
   {
        file.Write(text);
   }

    Console.WriteLine("Succed!!");
    Console.ReadLine();
    Menu();
}
