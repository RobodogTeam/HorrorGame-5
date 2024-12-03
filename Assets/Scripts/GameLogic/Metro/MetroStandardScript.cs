using UnityEngine;

public class MetroStandardScript : MonoBehaviour
{
    [SerializeField] 
    private MinecartStandardScript minecart;
    private ColliderScript trigger;
    

    void Start()
    {
        minecart.metro = this;
        trigger = GetComponentInChildren<ColliderScript>();
    }

    void Update()
    {
        if (trigger.IsTriggered && Input.GetKeyDown(KeyCode.F))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        minecart.StartMove();
    }

    public void EndGame()
    {

    }
}
