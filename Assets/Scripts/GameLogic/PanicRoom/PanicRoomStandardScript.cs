using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PanicRoomStandardScript : MonoBehaviour
{
    [SerializeField]
    protected Wardrobe wardrobe;

    protected bool isStart;
    protected TriggerScript trigger;
    protected bool isEnd;

    void Start()
    {
        trigger = GetComponentInChildren<TriggerScript>();
    }

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
