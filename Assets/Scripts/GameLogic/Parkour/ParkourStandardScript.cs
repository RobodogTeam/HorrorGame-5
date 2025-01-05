using UnityEngine;

public class ParkourStandardScript : MonoBehaviour
{
    [SerializeField]
    private Transform startPoint;
    [SerializeField]
    private TriggerScript deathTrigger;

    private Player player;

    void Start()
    { 
        player = Player.instance;
    }

    private void Update()
    {
        if (deathTrigger.IsTriggered)
        {
            player.transform.position = startPoint.position;
            player.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
            player.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        }
    }
}
