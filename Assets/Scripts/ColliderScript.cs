using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public bool IsTriggered { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsTriggered = false;
        }
    }
}
