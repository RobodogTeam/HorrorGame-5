using UnityEngine;

public class CarouselHorrorMove : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 targetPos;
    private Vector3 startPos;
    private int pos = 1;
    private bool isStart;

    void Start()
    {
        targetPos = transform.localPosition;
        startPos = transform.localPosition;
    }

    void Update()
    {
        if (isStart)
        {
            if (Input.GetKeyDown(KeyCode.D) && pos < 2)
            {
                pos++;
            }

            if (Input.GetKeyDown(KeyCode.A) && pos > 0)
            {
                pos--;
            }
            CheckPos();

            transform.localPosition = Vector3.Lerp(transform.localPosition, targetPos, speed * Time.deltaTime);
        }
    }

    private void CheckPos()
    {
        switch (pos)
        {
            case 0:
                targetPos.z = startPos.z - 1.5f;
                break;
            case 1:
                targetPos.z = startPos.z;
                break;
            case 2:
                targetPos.z = startPos.z + 1.5f;
                break;
        }
    }

    public void StartMoves()
    {
        isStart = true;
    }

    public void EndMoves()
    {
        transform.localPosition = startPos;
        isStart = false;
        pos = 1;
    }
}
