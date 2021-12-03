var names = new List<string>{"x","y","z"};
var foreachActions = new List<Action>();
var forActions = new List<Action>();
foreach (var name in names)
{
    foreachActions.Add(()=>Console.WriteLine(name));
}

for (var i = 0; i < names.Count; i++)
{
    forActions.Add((() => Console.WriteLine(names[i])));
}

foreach (var action in foreachActions)
{
    action();
}

foreach (var action in forActions)
{
    action();
}
