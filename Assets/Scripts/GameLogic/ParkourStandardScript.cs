using UnityEngine;

public class ParkourStandardScript : MonoBehaviour
{
    [SerializeField]
    private Transform deathPoint;
    [SerializeField]
    private Transform startPoint;

    private TriggerScript trigger;
    private Player player;

    void Start()
    {
        trigger = GetComponentInChildren<TriggerScript>();
        player = Player.instance;
    }

    private void Update()
    {
        if (trigger.IsTriggered)
        {
            player.transform.position = startPoint.position;
            player.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
            player.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        }
    }
}
