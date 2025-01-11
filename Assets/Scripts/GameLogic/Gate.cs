using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField]
    private Transform rightDoor, leftDoor;
    [SerializeField]
    private TriggerScript trigger;
    [SerializeField]
    private GameObject invisibleWallForBlocking;

    public int DegreesPerSecond;
    
    private bool isOpened;
    private bool isOpening;

    void Update()
    {
        if (trigger.IsTriggered && !isOpened)
        {
            Open();
        }

        if (isOpening)
        {
            if (leftDoor.localRotation.eulerAngles.y > 3)
            {
                float currentAngle = leftDoor.localRotation.eulerAngles.y;
                leftDoor.localRotation = 
                    Quaternion.Euler(leftDoor.localRotation.eulerAngles.x, currentAngle - Time.deltaTime * DegreesPerSecond, 0);
                rightDoor.localRotation =
                    Quaternion.Euler(rightDoor.localRotation.eulerAngles.x, - (currentAngle - Time.deltaTime * DegreesPerSecond), 0);
            }
            else
            {
                isOpening = false;
                isOpened = true;
            }
        }
    }

    public void Open()
    {
        isOpening = true;
        invisibleWallForBlocking.SetActive(true);
    }
}
