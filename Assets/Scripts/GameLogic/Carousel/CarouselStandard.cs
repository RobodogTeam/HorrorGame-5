using Unity.VisualScripting;
using UnityEngine;

public class CarouselStandard : MonoBehaviour
{
    public int RotatesCount = 2;
    public float DegreesPerSecond = 45f;
    public float RotationDegreesAmount = 90f;
    public Transform MoveObjectTransform;

    [SerializeField]
    private TriggerScript startCollider;
    [SerializeField]
    private Transform seatPosition;

    private float totalRotation = 0;
    private bool isStart;
    private Player player;

    private void Start()
    {
        player = Player.instance;
    }

    private void FixedUpdate()
    {
        if (startCollider.IsTriggered && Input.GetKeyDown(KeyCode.F))
        {
            StartGame();
        }
    }

    private void Update()
    {
        if (isStart)
        {
            if (Mathf.Abs(totalRotation) <= Mathf.Abs(RotatesCount * 360))
            {
                float currentAngle = transform.rotation.eulerAngles.y;
                transform.rotation = 
                    Quaternion.AngleAxis(currentAngle - (Time.deltaTime * DegreesPerSecond), Vector3.up);
                totalRotation += Time.deltaTime * DegreesPerSecond;
                player.transform.position = seatPosition.position;
            }
            else
            {
                EndGame();
            }
        }
    }

    private void StartGame()
    {
        isStart = true;
        player.TurnOffMoves();
        Player.instance.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.None;
        Player.instance.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Discrete;
    }

    private void EndGame()
    {
        isStart = false;
        player.TurnOnMoves();
        Player.instance.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
        Player.instance.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    }
}
