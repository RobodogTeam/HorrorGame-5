using UnityEngine;

public class MinecartStandardScript : MonoBehaviour
{
    [SerializeField]
    private Transform seatPlace;
    [SerializeField]
    private Transform finishPoint;
    private bool isStart;
    private Rigidbody body;
    private Player player;

    public MetroStandardScript metro;
    public int Speed;

    void Start()
    {
        player = Player.instance;
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isStart)
        {
            body.linearVelocity = transform.forward * Speed;
            player.transform.position = seatPlace.position;
            if (Vector3.Distance(transform.position, finishPoint.position) < 3)
            {
                isStart = false;
                player.TurnOnMoves();
                metro.EndGame();
                body.linearVelocity = Vector3.zero;
            }
        }
    }

    public void StartMove()
    {
        isStart = true;
        player.TurnOffMoves();
    }
}
