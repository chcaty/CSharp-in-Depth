static void MakeBreakfast()
{
    var cup = PourCoffee();
    Console.WriteLine("coffee is ready");

    var eggs = FryEggs(2);
    Console.WriteLine("eggs are ready");

    var bacon = FryBacon(3);
    Console.WriteLine("bacon is ready");

    var toast = ToastBread(2);
    ApplyButter(toast);
    ApplyJam(toast);
    Console.WriteLine("toast is ready");

    var oj = PourOJ();
    Console.WriteLine("oj is ready");
    Console.WriteLine("Breakfast is ready!");
}

static async void MakeBreakfastAsync()
{
    var cup = PourCoffee();
    Console.WriteLine("coffee is ready");

    var eggs = await FryEggsAsync(2);
    Console.WriteLine("eggs are ready");

    var bacon = await FryBaconAsync(3);
    Console.WriteLine("bacon is ready");

    var toast = await ToastBreadAsync(2);
    ApplyButter(toast);
    ApplyJam(toast);
    Console.WriteLine("toast is ready");

    var oj = PourOJ();
    Console.WriteLine("oj is ready");
    Console.WriteLine("Breakfast is ready!");
}


static Juice PourOJ()
{
    Console.WriteLine("Pouring orange juice");
    return new Juice();
}

static void ApplyJam(Toast toast) => 
    Console.WriteLine("Putting jam on the toast");

static void ApplyButter(Toast toast) =>
    Console.WriteLine("Putting butter on the toast");

static Toast ToastBread(int slices)
{
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("Putting a slice of bread in the toaster");
    }
    Console.WriteLine("Start toasting...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Remove toast from toaster");
    return new Toast();
}

static async Task<Toast> ToastBreadAsync(int slices)
{
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("Putting a slice of bread in the toaster");
    }
    Console.WriteLine("Start toasting...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Remove toast from toaster");
    return await Task.FromResult(new Toast());
}

static Bacon FryBacon(int slices)
{
    Console.WriteLine($"putting {slices} slices of bacon in the pan");
    Console.WriteLine("cooking first side of bacon...");
    Task.Delay(3000).Wait();
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("flipping a slice of bacon");
    }
    Console.WriteLine("cooking the second side of bacon...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Put bacon on plate");
    return new Bacon();
}

static Task<Bacon> FryBaconAsync(int slices)
{
    Console.WriteLine($"putting {slices} slices of bacon in the pan");
    Console.WriteLine("cooking first side of bacon...");
    Task.Delay(3000).Wait();
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("flipping a slice of bacon");
    }
    Console.WriteLine("cooking the second side of bacon...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Put bacon on plate");
    return Task.FromResult(new Bacon());
}

static Egg FryEggs(int howMany)
{
    Console.WriteLine("Warming the egg pan...");
    Task.Delay(3000).Wait();
    Console.WriteLine($"cracking {howMany} eggs");
    Console.WriteLine("cooking the eggs ...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Put eggs on plate");
    return new Egg();
}

static Task<Egg> FryEggsAsync(int howMany)
{
    Console.WriteLine("Warming the egg pan...");
    Task.Delay(3000).Wait();
    Console.WriteLine($"cracking {howMany} eggs");
    Console.WriteLine("cooking the eggs ...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Put eggs on plate");
    return Task.FromResult(new Egg());
}

static Coffee PourCoffee()
{
    Console.WriteLine("Pouring coffee");
    return new Coffee();
}

public class Juice { }

public class Bacon { }

public class Egg { }

public class Coffee { }

public class Toast { }
