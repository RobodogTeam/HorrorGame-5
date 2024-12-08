using UnityEngine;

public class MazeStandardScript : MonoBehaviour
{
    [SerializeField] 
    private TriggerScript checkTeleportTrigger, teleportTrigger;

    private bool isStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkTeleportTrigger.IsTriggered)
        {
            StartGame();
        }
        if (teleportTrigger.IsTriggered && isStart)
        {
            // переключение на сцену хоррор версии
            Debug.Log("переключение на сцену хоррор версии");
        }
    }

    public void StartGame()
    {
        isStart = true;
    }
}
