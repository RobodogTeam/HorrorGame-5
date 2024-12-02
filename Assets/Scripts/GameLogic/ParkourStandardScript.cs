using UnityEngine;

public class ParkourStandardScript : MonoBehaviour
{
    [SerializeField]
    private Transform deathPoint;
    [SerializeField]
    private Transform startPoint;

    private ColliderScript trigger;
    private Player player;

    void Start()
    {
        trigger = GetComponentInChildren<ColliderScript>();
        player = Player.instance;
    }

    private void Update()
    {
        if (trigger.isTriggered)
        {
            player.transform.position = startPoint.position;
        }
    }
}
