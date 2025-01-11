using UnityEngine;

public class PanicRoomMonster : MonoBehaviour
{
    [SerializeField]
    private TriggerScript centerTrigger, doorTrigger;

    [SerializeField]
    private Transform centerPosition, doorPosition;

    private bool isStart;

    private void FixedUpdate()
    {
        if (centerTrigger.IsTriggered && isStart)
        {
            transform.position = doorPosition.position;
        }
        if (doorTrigger.IsTriggered && isStart)
        {
            gameObject.SetActive(false);
        }
    }

    public void StartInteraction()
    {
        isStart = true;
        transform.position = centerPosition.position;
    }
}
