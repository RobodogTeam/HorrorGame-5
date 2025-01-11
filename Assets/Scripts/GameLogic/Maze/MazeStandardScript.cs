using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeStandardScript : MonoBehaviour
{
    [SerializeField] 
    private Transform startPoint, endPoint;
    [SerializeField]
    private int speed;
    [SerializeField]
    private Transform moveObject;
    [SerializeField]
    private TriggerScript startTrigger;

    private bool isStart;
    private Player player;

    private void Start()
    {
        player = Player.instance;
    }

    void FixedUpdate()
    {
        if (!isStart && startTrigger.IsTriggered)
        {
            StartGame();
        }
        if (isStart)
        {
            moveObject.position = Vector3.Lerp(moveObject.position, endPoint.position, Time.fixedDeltaTime);
            player.transform.position = moveObject.position;

            if (Vector3.Distance(moveObject.position, endPoint.position) < 0.5f)
            {
                SceneManager.LoadScene("MainHorrorScene");
                enabled = false;
            }
        }
    }

    private void StartGame()
    {
        isStart = true;
        player.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.None;
        player.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Discrete;
        player.TurnOffMoves();
    }
}
