using UnityEngine;

public class MazeStandardScript : MonoBehaviour
{
    [SerializeField] 
    private TriggerScript checkTeleportTrigger, teleportTrigger;

    private bool isStart;

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
