using System.Collections;
using System.Collections.Specialized;


// 使用数组创建并打印 names
static string[] GenerateNamesByArray()
{
    string[] names = new string[4];
    names[0] = "Gamma";
    names[1] = "Vlissides";
    names[2] = "Johnson";
    names[3] = "Helm";
    return names;
}

static void PrintNamesByArray(string[] names)
{
    foreach (string name in names)
        Console.WriteLine(name);
}

PrintNamesByArray(GenerateNamesByArray());

// 使用 ArrayList 创建并打印 names
static ArrayList GenerateNamesByArrayList()
{
    ArrayList names = new();
    names.Add("Gamma");
    names.Add("Vlissides");
    names.Add("Johnson");
    names.Add("Helm");
    return names;
}

static void PrintNamesByArrayList(ArrayList names)
{
    foreach (string name in names)
        Console.WriteLine(name);
}

PrintNamesByArrayList(GenerateNamesByArrayList());

// 使用 StringCollection 创建并打印 names
static StringCollection GenerateNamesByStringCollection()
{
    StringCollection names = new();
    names.Add("Gamma");
    names.Add("Vlissides");
    names.Add("Johnson");
    names.Add("Helm");
    return names;
}

static void PrintNamesByStringCollection(StringCollection names)
{
    foreach (string name in names)
        Console.WriteLine(name);
}

PrintNamesByStringCollection(GenerateNamesByStringCollection());

// 使用 List<T> 创建并打印 names
static List<string> GenerateNamesByList()
{
    List<string> names = new();
    names.Add("Gamma");
    names.Add("Vlissides");
    names.Add("Johnson");
    names.Add("Helm");
    return names;
}

static void PrintNamesByList(List<string> names)
{
    foreach (string name in names)
        Console.WriteLine(name);
}

PrintNamesByList(GenerateNamesByList());

