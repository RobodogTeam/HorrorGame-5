using UnityEngine;


public class TaskNPCScript : MonoBehaviour
{
    private Player player;
    private Task task;
    private bool isGiveTask;
    private ColliderScript taskCollider;

    [SerializeField]
    private string taskName;
    [SerializeField]
    public string taskDescription;
    [SerializeField]
    public TaskObject taskObject;
    [SerializeField]
    public TaskNPCScript taskFinishNPC;
    [SerializeField]
    public string taskFinishText;

    private void Start()
    {
        isGiveTask = false;
        player = Player.instance;
        taskCollider = GetComponentInChildren<ColliderScript>();
        task = new Task(taskName, taskDescription, taskFinishText, taskObject, taskFinishNPC);
    }

    private void FixedUpdate()
    {
        if (taskCollider.isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            if (!isGiveTask)
            {
                player.StartTask(task);
                SayPhrase(task.Description);
                isGiveTask = true;
            }
            else
            {
                task.TryToFinish();
            }
        }
    }

    public void SayPhrase(string phrase)
    {
        Debug.Log(phrase);
    }
}