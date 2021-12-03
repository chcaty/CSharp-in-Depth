namespace AsyncConsole
{
    internal static class AsyncFunc
    {
        internal static Func<int, Task<int>> function = async x =>
        {
            Console.WriteLine($"Starting...x={x}");
            await Task.Delay(x * 1000);
            Console.WriteLine($"Finished...x={x}");
            return x * 2;
        };
    }
}
