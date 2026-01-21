namespace MightyRakunWebApp;

public interface IAnimal
{
    void Eat();
}

public struct Raccoon : IAnimal
{
    public void Eat()
    {
        throw new NotImplementedException();
    }
}

public sealed class ASD
{
    public static string Name => "ASD";
    public string Surname => 1 + "XXX";

    public void Test()
    {
        
        Test2(new Raccoon());
    }

    public void Test2(IAnimal animal)
    {
        animal.Eat();
        if (true)
        {
            return;
        }
        
        GetAnimals()
            .Where(e => )
            .Select(e => e)
            .ToList();
    }
    
    private IEnumerable<IAnimal> GetAnimals()
    {
        yield return new Raccoon();
        yield return new Raccoon();
        yield return new Raccoon();
        yield return new Raccoon();
        yield return new Raccoon();

        if (true)
        {
            yield return new Raccoon();
            yield break;
        }
        
        yield return new Raccoon();
        yield return new Raccoon();
        yield return new Raccoon();
    }
}



public class Test
{
    public delegate void MyFunc(Int16 asd);
    
    public void Example()
    {
        var a = 0b0000001;
        var b = a << 1;

        object test = "asdasd";
        int xxx = (int)test;
        
        List<MyFunc> listOfListeners = [Example2, Example4];
        foreach (var listener in listOfListeners)
        {
            Example3(listener);
        }
        
        MyFunc qwe = Example2;
        qwe(123);
    }

    public void Example2(Int16 a)
    {
        
    }
    
    public void Example4(Int16 a)
    {
        
    }

    public void Example3(MyFunc asdqwe)
    {
        asdqwe(123);
    }

    public void Example5(Action asdasd)
    {
        asdasd();
    }

    public void Example6(Action<long> asdasd)
    {
        asdasd(123123);
    }

    public void Example7(Func<short> asdasd)
    {
        var shortValue = asdasd();
    }
    
    public void Example8(Func<short, string> asdasd)
    {
        var stringValue = asdasd(123);
    }
}