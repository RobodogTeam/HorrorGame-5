using UnityEngine;

public class CarouselHorrorScript : MonoBehaviour
{
    public int RotatesCount = 2;
    public float DegreesPerSecond = 45f;
    public float RotationDegreesAmount = 90f;
    public Transform MoveObject, RestartPosition;

    [SerializeField]
    private CarouselHorrorMove horrorMove;
    [SerializeField]
    private CarouselEnemy enemy;
    [SerializeField]
    private TriggerScript actionCollider;

    private float totalRotation = 0;
    private bool isStart;
    private Player player;

    private void Start()
    {
        player = Player.instance;
    }

    private void FixedUpdate()
    {
        if (actionCollider.IsTriggered && Input.GetKeyDown(KeyCode.F))
        {
            StartGame();
        }
    }

    private void Update()
    {
        if (isStart)
        {
            if (actionCollider.IsTriggered)
            {
                enemy.ChangePos();
            }
            if (Mathf.Abs(totalRotation) <= Mathf.Abs(RotatesCount * 360))
            {
                float currentAngle = transform.rotation.eulerAngles.y;
                transform.rotation =
                    Quaternion.AngleAxis(currentAngle + (Time.deltaTime * DegreesPerSecond), Vector3.up);
                totalRotation += Time.deltaTime * DegreesPerSecond;
                player.transform.position = MoveObject.position;
            }
            else
            {
                EndGame();
            }
        }
    }

    private void StartGame()
    {
        totalRotation = 0;
        isStart = true;
        player.TurnOffMoves();
        horrorMove.StartMoves();
        player.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.None;
        player.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Discrete;
        enemy.gameObject.SetActive(true);
    }

    private void EndGame()
    {
        isStart = false;
        player.TurnOnMoves();
        horrorMove.EndMoves();
        enemy.gameObject.SetActive(false);
    }

    public void Restart()
    {
        EndGame();
        player.transform.position = RestartPosition.position;
        enemy.gameObject.SetActive(false);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
