using UnityEngine;

public class PanicRoomStandardScript : MonoBehaviour
{
    [SerializeField]
    private Transform rightDoor, leftDoor;

    private bool isStart;
    private TriggerScript trigger;

    public int DegreesPerSecond;

    void Start()
    {
        trigger = GetComponentInChildren<TriggerScript>();
    }

    void Update()
    {
        if (trigger.IsTriggered && leftDoor.rotation.eulerAngles.y < 123)
        {
            StartGame();
        }

        if (isStart)
        {
            if (leftDoor.rotation.eulerAngles.y < 123)
            {
                float currentAngle = leftDoor.rotation.eulerAngles.y;
                leftDoor.rotation =
                    Quaternion.AngleAxis(currentAngle + (Time.deltaTime * DegreesPerSecond), Vector3.up);
                rightDoor.rotation =
                    Quaternion.AngleAxis(- (currentAngle + (Time.deltaTime * DegreesPerSecond)), Vector3.up);
            }
            else
            {
                EndGame();
            }
        }
    }

    public void StartGame()
    {
        isStart = true;
    }

    public void EndGame()
    {
        isStart = false;
    }
}
