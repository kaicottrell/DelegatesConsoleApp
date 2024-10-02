
/// <summary>
/// Code sourced from the Pluralsight course "C# Events, Delegates, and Lambdas" by Dan Wahlin
/// </summary>

var del1 = new WorkPerformedHandler(WorkPerformed1);
var del2 = new WorkPerformedHandler(WorkPerformed2);
del1+=del2; //Combines the two delegates into one delegate, allowing for two functions to be called at once
//Invokes the delegate, but is called like a function. Dumps the data from the pipeline (delgate) into the endpoint called WorkPerformed1
int finalHours = del1(10, WorkType.Golf);
static int WorkPerformed1(int hours, WorkType workType)
{
    Console.WriteLine($"WorkPerformed1 called: {hours}");
    return hours + 1;
}
static int WorkPerformed2(int hours, WorkType workType)
{
    Console.WriteLine($"WorkPerformed2 called: {workType}");
    return hours + 1;
}
//Delegates are technically classes that inherit from System.MulticastDelegate
//But why do we use this?
public delegate int WorkPerformedHandler(int hours, WorkType workType);
public enum WorkType
{
    GoToMeetings,
    Golf,
    GenerateReports
}
