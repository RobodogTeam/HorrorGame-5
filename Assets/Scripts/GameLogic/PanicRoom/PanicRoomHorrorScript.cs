using System.Threading;
using UnityEngine;

public class PanicRoomHorrorScript : PanicRoomStandardScript
{
    [SerializeField]
    private PanicRoomMonster monster;

    void Update()
    {
        if (trigger.IsTriggered && !wardrobe.IsOpen && !isEnd)
        {
            StartGame();
        }

        if (isStart)
        {
            if (wardrobe.IsOpen)
            {
                monster.StartInteraction();
                EndGame();
            }
        }
    }
}
