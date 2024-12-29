using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    [SerializeField]
    private Transform rightDoor, leftDoor;

    public int DegreesPerSecond;
    public bool IsOpen => isOpening;

    private bool isOpening;

    void Update()
    {
        if (isOpening)
        {
            if (leftDoor.rotation.eulerAngles.y < 123)
            {
                float currentAngle = leftDoor.rotation.eulerAngles.y;
                leftDoor.rotation =
                    Quaternion.AngleAxis(currentAngle + (Time.deltaTime * DegreesPerSecond), Vector3.up);
                rightDoor.rotation =
                    Quaternion.AngleAxis(-(currentAngle + (Time.deltaTime * DegreesPerSecond)), Vector3.up);
            }
            else
            {
                isOpening = false;
            }
        }
    }

    public void Open()
    {
        isOpening = true;
    }
}
