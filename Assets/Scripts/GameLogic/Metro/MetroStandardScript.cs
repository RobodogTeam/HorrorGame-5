using UnityEngine;

public class MetroStandardScript : MonoBehaviour
{
    [SerializeField] 
    private MinecartStandardScript minecart;
    [SerializeField]
    private TriggerScript trigger;
    [SerializeField]
    private GameObject TaskGameObject;

    void Start()
    {
        minecart.metro = this;
    }

    void Update()
    {
        if (trigger.IsTriggered)
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
        minecart.EndMove();
        Player.instance.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
        Player.instance.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        Player.instance.transform.position = minecart.transform.position;
        TaskGameObject.SetActive(false);
    }
}
