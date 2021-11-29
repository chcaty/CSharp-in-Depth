// 一个生成整型值的简单方法
static IEnumerable<int> CreateSimpleIterator()
{
    yield return 10;
    for (var i = 0; i < 3; i++)
    {
        yield return i;
    }

    yield return 20;
}

Console.WriteLine("一个生成整型值的简单方法:");
foreach (var value in CreateSimpleIterator())
{
    Console.WriteLine(value);
}
Console.WriteLine();

// 扩展 foreach 循环
var enumerable = CreateSimpleIterator();
Console.WriteLine("扩展 foreach 循环:");
using var enumerator = enumerable.GetEnumerator();
while (enumerator.MoveNext())
{
    var value = enumerator.Current;
    Console.WriteLine(value);
}
Console.WriteLine();

// 迭代斐波那契数列
static IEnumerable<int> Fibonacci()
{
    var current = 0;
    var next = 1;
    while (true)
    {
        yield return current;
        var oldCurrent = current;
        current = next;
        next += oldCurrent;
    }
}

Console.WriteLine("迭代斐波那契数列:");
foreach (var value in Fibonacci())
{
    Console.WriteLine(value);
    if(value>1000)
        break;
}
Console.WriteLine();

//一个用于记录执行进度的迭代器
static IEnumerable<string> Iterator()
{
    try
    {
        Console.WriteLine("Before first yield");
        yield return "first";
        Console.WriteLine("Between yields");
        yield return "second";
        Console.WriteLine("After second yield");
    }
    finally
    {
        Console.WriteLine("In finally block");
    }
}

Console.WriteLine("一个用于记录执行进度的迭代器:");
foreach (var value in Iterator())
{
    Console.WriteLine("Received value:{0}",value );
}
Console.WriteLine();

// 使用迭代器退出foreach循环
foreach (var value in Iterator())
{
    Console.WriteLine("Received value:{0}", value);
    break;
}