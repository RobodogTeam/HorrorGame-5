using UnityEngine;

public class TaskCompleter : MonoBehaviour
{
    public GameObject TaskGameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TaskGameObject.SetActive(false);
        }
    }
}
