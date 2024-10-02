public class WorkPerformedEventArgs
{
    public WorkPerformedEventArgs(int hours, WorkType workType)
    {
        Hours = hours;
        WorkType = workType;
    }
    public int Hours { get; set; }
    public WorkType WorkType { get; set; }
}