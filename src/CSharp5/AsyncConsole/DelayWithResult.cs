namespace AsyncConsole
{
    internal static class DelayWithResult
    {
        public static async Task DelayWithResultOfUnsafeCode(string text)
        {
            var total = 0;
            unsafe
            {
                fixed (char* textPointer = text)
                {
                    char* p = textPointer;
                    while (*p != 0)
                    {
                        total += *p;
                        p++;
                    }
                }
            }
            Console.WriteLine($"Delaying for {total} ms");
            await Task.Delay(total);
            Console.WriteLine("Delay Complete");
        }
    }
}
