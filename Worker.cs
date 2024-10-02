public delegate int WorkPerformedHandler(int hours, WorkType workType);

public class Worker
{
    public event WorkPerformedHandler? WorkPerformed;
    //Built in delegate that takes in an object and an EventArgs object
    public event EventHandler? WorkCompleted;

    public void DoWork(int hours, WorkType workType)
    {
        for (int i = 0; i < hours; i++)
        {
            //Add delay for demonstration purposes
            Thread.Sleep(1000);
            OnWorkPerformed(i + 1, workType);
        }
        OnWorkCompleted();
       
    }
    protected virtual void OnWorkPerformed(int hours, WorkType workType)
    {
        //If there are any subscribers to the event, invoke the event
        WorkPerformed?.Invoke(hours, workType);
    }
    /// <summary>
    /// Lets subscribers know that the work has been completed
    /// </summary>
    protected virtual void OnWorkCompleted()
    {
        //If there are any subscribers to the event, invoke the event
        //This is the class worker invoking the event
        WorkCompleted?.Invoke(this, EventArgs.Empty);
    }
}

