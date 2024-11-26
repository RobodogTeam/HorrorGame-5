using UnityEngine;

public class Task
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string FinishText { get; private set; }
    public TaskObject TaskObject { get; private set; }
    public TaskNPCScript FinishNPC { get; private set; }
    public bool IsReady { get; private set; }

    public Task(string name, string description, string finishText, TaskObject taskObject, TaskNPCScript finishNPC)
    {
        this.Name = name;
        this.Description = description;
        this.FinishText = finishText;
        this.TaskObject = taskObject;
        this.FinishNPC = finishNPC;
        TaskObject.task = this;
    }

    public void PrepareToFinish()
    {
        IsReady = true;
    }

    public void TryToFinish()
    {
        if (IsReady)
        {
            FinishNPC.SayPhrase(FinishText);
        }
    }
}
