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
            // ������������ �� ����� ������ ������
            Debug.Log("������������ �� ����� ������ ������");
        }
    }

    public void StartGame()
    {
        isStart = true;
    }
}
