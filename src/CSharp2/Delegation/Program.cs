

static void PrintAnything(object obj)
{
    Console.WriteLine(obj);
}

GeneralPrinter generalPrinter = new GeneralPrinter(PrintAnything);
Printer p1 = new Printer(generalPrinter);
Printer p2 = PrintAnything;

Console.WriteLine(p1);
Console.WriteLine(p2);

public delegate void Printer(string message);

public delegate void GeneralPrinter(object obj);


