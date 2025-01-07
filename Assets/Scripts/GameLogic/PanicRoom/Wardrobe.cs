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
            Debug.Log(2);
            if (leftDoor.localRotation.eulerAngles.y < 123)
            {
                float currentAngle = leftDoor.localRotation.eulerAngles.y;
                leftDoor.localRotation =
                    Quaternion.AngleAxis(currentAngle + (Time.deltaTime * DegreesPerSecond), Vector3.up);
                rightDoor.localRotation =
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
