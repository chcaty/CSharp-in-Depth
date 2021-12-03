using AsyncConsole;

await DelayWithResult.DelayWithResultOfUnsafeCode("caty");

Task task = CompleteAsync.DemoCompletedAsync();
//await DemoCompletedAsync();
//Task.Run(DemoCompletedAsync);
Console.WriteLine("Method returned");
//task.Wait();
Console.WriteLine("Task completed");
Console.ReadKey();

var first = AsyncFunc.function(5);
var second = AsyncFunc.function(3);
Console.WriteLine($"First result:{first.Result}");
Console.WriteLine($"Second result:{second.Result}");