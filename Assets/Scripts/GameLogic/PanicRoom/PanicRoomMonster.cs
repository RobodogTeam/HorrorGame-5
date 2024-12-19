using UnityEngine;

public class PanicRoomMonster : MonoBehaviour
{
    [SerializeField]
    private TriggerScript centerTrigger, doorTrigger;

    private bool isStart;

    private void FixedUpdate()
    {
        if (centerTrigger.IsTriggered && isStart)
        {
            transform.position = doorTrigger.transform.position;
        }
        if (doorTrigger.IsTriggered && isStart)
        {
            gameObject.SetActive(false);
        }
    }

    public void StartInteraction()
    {
        isStart = true;
        transform.position = centerTrigger.transform.position;
    }
}
