var tasks = new List<Task>();

static async Task A(object? obj)
{
    int i = (int)(obj ?? 0);
    Console.WriteLine("Task={0}", Task.CurrentId);
    await Task.Delay(i * 100);
    int tickCount = Environment.TickCount;
    Console.WriteLine("Task={0}, i={1}, TickCount={2}, Thread={3}", Task.CurrentId, i, tickCount, Thread.CurrentThread.ManagedThreadId);
};

static async Task<int> Add(int i)
{
   return await Task.FromResult(i + i);
}

static async Task Add1(int i)
{ 
    Console.WriteLine("a");
}

for (var i = 0; i < 10; i++)
{
    var i1 = i;
    tasks.Add(Task.Run(() => A(i1)));
}
Task.WaitAll(tasks.ToArray());
Console.WriteLine("WaitAll() has not thrown exceptions. THIS WAS NOT EXPECTED.");
Console.ReadKey();
