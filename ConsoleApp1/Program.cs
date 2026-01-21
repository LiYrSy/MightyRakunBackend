// See https://aka.ms/new-console-template for more information

try
{
    object a = "132";
    if (int.TryParse(a, out var parsedValue))
    {
        Console.WriteLine(parsedValue);
    }
    else
    {
        Console.WriteLine("Not a number");
    }

    int? asd = null;
    
    Console.WriteLine("Done");
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}\r\n{ex.StackTrace}");
}


var sobaka = getSobaka() ?? "Pushistaja";

string? getSobaka()
{
    var asd = from a in sobaka
        select a;

    var dsa = sobaka
        .Where(e => char.IsDigit(e))
        .Select(e => (int)e)
        .ToList();

    
    var stream = File.Open("asdasd");
    
    var sum = 0;
    foreach (var e in sobaka)
    {
        if (char.IsDigit(e))
        {
            sum += e;
        }
    }
    
    return null;
}

List<object> animals = [1, ""];

List<string> sp = ["", ""];
object[] asdsss = [1, ""];
