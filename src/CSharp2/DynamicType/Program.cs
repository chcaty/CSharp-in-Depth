using System.Dynamic;

dynamic text = "hello world";
string world = text.Substring(6);
Console.WriteLine(world);

//string broken = text.SUBSTR(6);
//Console.WriteLine(broken);

static void Add(dynamic d)
{
    Console.WriteLine(d + d);
}

Add("text");
Add(10);
Add(TimeSpan.FromMinutes(45));

dynamic expando = new ExpandoObject();
expando.SomeData = "Some data";

static void Action1(string input) => Console.WriteLine($"The input was '{input}'");
expando.FakeMethod = (Action<string>)Action1; 
//Console.WriteLine(expando.SomeData);
expando.FakeMethod("hello");

IDictionary<string,object> dictionary = expando;
//Console.WriteLine($"Keys:{string.Join(", ", dictionary.Keys)}");

dictionary["OtherData"] = "other";
Console.WriteLine(expando.OtherData);
Console.WriteLine(dictionary["FakeMethod"]);

dynamic example = new SimpleDynamicExample();
example.CallSomeMethod("X", 10);
Console.WriteLine(example.SomeProperty);

var source = new List<dynamic>
{
    5, 2.75, TimeSpan.FromSeconds(45)
};
var query = source.Select(x => x * 2);
foreach (var value in query)
{
    Console.WriteLine(value);
}

class SimpleDynamicExample : DynamicObject
{
    public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
    {
        if(args!=null)
            Console.WriteLine($"Invoked: {binder.Name}({string.Join(", ", args)})");
        result = null;
        return true;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        result = $"Fetched: {binder.Name}";
        return true;
    }
}