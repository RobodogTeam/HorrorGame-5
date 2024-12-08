using UnityEngine;

public class MetroStandardScript : MonoBehaviour
{
    [SerializeField] 
    private MinecartStandardScript minecart;
    private TriggerScript trigger;
    

    void Start()
    {
        minecart.metro = this;
        trigger = GetComponentInChildren<TriggerScript>();
    }

    void Update()
    {
        if (trigger.IsTriggered && Input.GetKeyDown(KeyCode.F))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        minecart.StartMove();
        Player.instance.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.None;
        Player.instance.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Discrete;
    }

    public void EndGame()
    {

    }
}
