using UnityEngine;

public class TaskObject : MonoBehaviour
{
    public Task task;
    private bool isTriggered;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = false;
        }
    }

    private void FixedUpdate()
    {
        if (isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            task.PrepareToFinish();
            Debug.Log("подобрал");
            Destroy(gameObject);
        }
    }
}
