using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PanicRoomStandardScript : MonoBehaviour
{
    [SerializeField]
    protected Wardrobe wardrobe;
    [SerializeField]
    protected TriggerScript trigger;

    protected bool isStart;
    protected bool isEnd;

    void Update()
    {
        if (trigger.IsTriggered && !isEnd)
        {
            StartGame();
        }

        if (isStart)
        {
            if (wardrobe.IsOpen)
            {
                EndGame();
            }
        }
    }

    public void StartGame()
    {
        isStart = true;
        wardrobe.Open();
    }

    public void EndGame()
    {
        isStart = false;
        isEnd = true;
    }
}
