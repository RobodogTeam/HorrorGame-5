using UnityEngine;

public class ParkourHorrorScript : MonoBehaviour
{
    [SerializeField]
    private Transform startPoint;
    [SerializeField]
    private TriggerScript deathtTrigger, playTrigger;
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
        if (deathtTrigger.IsTriggered)
        {
            player.SetRestartPoint(startPoint);
            player.Death();
        }
    }
}
