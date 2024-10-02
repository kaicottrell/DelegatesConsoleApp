
/// <summary>
/// Code sourced from the Pluralsight course "C# Events, Delegates, and Lambdas" by Dan Wahlin
/// </summary>

var custs = new List<Customer>
{
    new Customer ("Phoenix", "John", "Doe", 1 ),
    new Customer  ("Phoenix", "John", "Doe", 500 ),
    new Customer  ("Seattle", "Suki", "Pizzoro", 500 ),
    new Customer  ("NY City", "Michelle", "Smith", 500 ),
};
//Uses lambda expression to filter and order the list
var phxCusts = custs
    .Where(c => c.City == "Phoenix" && c.Id < 500)
    .OrderBy(c => c.FirstName);
   
foreach (var cust in phxCusts)
{
    Console.WriteLine(cust.FirstName);
}
var data = new ProcessData();
//Delegates
BizRulesDelegate addDel = (x, y) => x + y;
BizRulesDelegate multiplyDel = (x, y) => x * y;
data.Process(2, 3, addDel);
data.Process(2, 3, multiplyDel);
//Actions
Action<int, int> myAddAction = (x, y) => Console.WriteLine(x + y); 
Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
data.ProcessAction(2, 3, myAddAction);
data.ProcessAction(2, 3, myMultiplyAction);
//Funcs
Func<int, int, int> addFunc = (x, y) => x + y;  
Func<int, int, int> multiplyFunc = (x, y) => x * y;
data.ProcessFunc(3, 2, addFunc);
data.ProcessFunc(3, 2, multiplyFunc);
var worker = new Worker();
//WorkPerformed is the event, EventHandler is the delegate provided by .net, WorkerPerformedEventArgs are our custom values,Worker_WorkPerformed is the event handler
//Lambda example (shorthand method): 
worker.WorkPerformed += (s, e) =>
{
    Console.WriteLine($"Hours worked: {e.Hours}, Work Type: {e.WorkType}");
    Console.WriteLine("Lambda expression");
};
worker.WorkCompleted += (s, e) => Console.WriteLine("Work is Complete");
worker.DoWork(8, WorkType.GenerateReports);
public enum WorkType
{
    GoToMeetings,
    Golf,
    GenerateReports
}

