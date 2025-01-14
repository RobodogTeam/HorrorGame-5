using UnityEngine;
using UnityEngine.AI;

public class MazeMonster : MonoBehaviour
{
    [SerializeField]
    private TriggerScript lookTrigger, killTrigger;
    [SerializeField]
    private Transform restartPosition, startPosition;

    private Player player;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = Player.instance;
    }

    void Update()
    {
        if (lookTrigger.IsTriggered)
        {
            agent.SetDestination(player.transform.position);
        }
        if (killTrigger.IsTriggered)
        {
            player.SetRestartPoint(restartPosition);
            player.Death();
            agent.SetDestination(startPosition.position);
        }
    }
}
