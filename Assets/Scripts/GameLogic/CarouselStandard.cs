using Unity.VisualScripting;
using UnityEngine;

public class CarouselStandard : MonoBehaviour
{
    public int RotatesCount = 2;
    public float DegreesPerSecond = 45f;
    public float RotationDegreesAmount = 90f;
    public Transform MoveObjectTransform;

    private float totalRotation = 0;
    private ColliderScript actionCollider;
    private bool isStart;
    private Player player;

    private void Awake()
    {
        actionCollider = GetComponentInChildren<ColliderScript>();
    }

    private void Start()
    {
        player = Player.instance;
    }

    private void FixedUpdate()
    {
        if (actionCollider.isTriggered && Input.GetKeyDown(KeyCode.F))
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
                    Quaternion.AngleAxis(currentAngle + (Time.deltaTime * DegreesPerSecond), Vector3.up);
                totalRotation += Time.deltaTime * DegreesPerSecond;
                player.transform.position = MoveObjectTransform.position;
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
    }

    private void EndGame()
    {
        isStart = false;
        player.TurnOnMoves();
    }
}
