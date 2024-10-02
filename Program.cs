
/// <summary>
/// Code sourced from the Pluralsight course "C# Events, Delegates, and Lambdas" by Dan Wahlin
/// </summary>

///<summary>
/// Event handler for the WorkPerformed event
/// </summary>
static void Worker_WorkPerformed(object? sender, WorkPerformedEventArgs e)
{
    Console.WriteLine($"Hours worked: {e.Hours}, Work Type: {e.WorkType}");
}
///<summary>
/// Event handler for the WorkCompleted event
/// </summary>
static void Worker_WorkCompleted(object? sender, EventArgs e)
{
    Console.WriteLine("Work is done");
}

var worker = new Worker();
//WorkPerformed is the event, EventHandler is the delegate provided by .net, WorkerPerformedEventArgs are our custom values,Worker_WorkPerformed is the event handler
//Delegate Inference: 
worker.WorkPerformed += Worker_WorkPerformed;
worker.WorkCompleted += Worker_WorkCompleted;
worker.DoWork(8, WorkType.GenerateReports);
public enum WorkType
{
    GoToMeetings,
    Golf,
    GenerateReports
}

