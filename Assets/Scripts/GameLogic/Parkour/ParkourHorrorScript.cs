using UnityEngine;

public class ParkourHorrorScript : MonoBehaviour
{
    [SerializeField]
    private Transform deathPoint;
    [SerializeField]
    private Transform startPoint;
    [SerializeField]
    private TriggerScript deathtTigger, playTrigger;
    [SerializeField]
    private ParkourBlock[] parkourBlocks;

    private Player player;

    public bool isPlaying => playTrigger.IsTriggered;

    void Start()
    {
        player = Player.instance;
        foreach (var block in parkourBlocks)
        {
            block.SetMainScript(this);
        }
    }

    private void Update()
    {
        if (deathtTigger.IsTriggered)
        {
            player.SetRestartPoint(startPoint);
            player.Death();
        }
    }
}
