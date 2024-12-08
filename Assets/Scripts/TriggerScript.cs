using UnityEngine;

public class TriggerScript : MonoBehaviour
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

    public void SetTriggered(bool value)
    {
        IsTriggered = value;
    }
}
