static async Task DelayWithResultOfUnsafeCode(string text)
 {
     var total = 0;
     unsafe
     {
         fixed (char* textPointer = text)
         {
             char* p = textPointer;
             while (*p !=0)
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
 
 //await DelayWithResultOfUnsafeCode("caty");

async Task DownloadImage(string path)
{
    Console.WriteLine("download await");
    var client = new HttpClient();
    const string url = "http://pic.616pic.com/bg_w1180/00/03/37/RXpRReG8xr.jpg!/fw/1120";
    for (var i = 1; i <= 1000; i++)
    {
        var filename =
            $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}({i}).jpg";
        var filepath = @$"F:\{path}\" + filename;
        var urlContent = await client.GetByteArrayAsync(new Uri(url));
        var fs = new FileStream(filepath, FileMode.OpenOrCreate);
        await fs.WriteAsync(urlContent);
    }
}

async Task DemoCompletedAsync()
{
    Console.WriteLine("Before first await");
    Console.WriteLine("Between awaits");
    var ts1 = DownloadImage("test1");
    Console.WriteLine("After second await");
    var ts2 = DownloadImage("test2");
    await Task.Delay(500);
    ts1.Wait();
    ts2.Wait();
}

Task task = DemoCompletedAsync();
//await DemoCompletedAsync();
//Task.Run(DemoCompletedAsync);
Console.WriteLine("Method returned");
task.Wait();
Console.WriteLine("Task completed");
