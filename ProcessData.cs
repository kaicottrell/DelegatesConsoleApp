public delegate int BizRulesDelegate(int x, int y); 

public class ProcessData
{ 
    //Pass me any function that returns an int and takes two ints
    public void Process(int x, int y, BizRulesDelegate del)
    {
        var result = del(x, y);
        Console.WriteLine(result);
    }
    //Pass me a function that returns void and takes two ints
    public void ProcessAction(int x, int y, Action<int, int> action)
    {
        action(x, y);
        Console.WriteLine("Action has been processed");
    }
    public void ProcessFunc(int x, int y, Func<int, int, int> func)
    {
        var result = func(x, y);
        Console.WriteLine(result);
    }
}   