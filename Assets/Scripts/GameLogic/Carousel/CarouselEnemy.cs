using UnityEngine;

public class CarouselEnemy : MonoBehaviour
{
    private Vector3 targetPos;
    private Vector3 startPos;
    private int pos = 1;
    private TriggerScript trigger;

    [SerializeField]
    private CarouselHorrorScript horrorGame;


    void Start()
    {
        targetPos = transform.localPosition;
        startPos = transform.localPosition;
        trigger = GetComponent<TriggerScript>();
    }

    public void ChangePos() => 
        pos = Random.Range(0, 2);

    void Update()
    {
        CheckPos();
        transform.localPosition = targetPos;
        if (trigger.IsTriggered)
        {
            horrorGame.Restart();
            trigger.SetTriggered(false);
        }
    }

    private void CheckPos()
    {
        switch (pos)
        {
            case 0:
                targetPos.z = startPos.z - 1f;
                break;
            case 1:
                targetPos.z = startPos.z;
                break;
            case 2:
                targetPos.z = startPos.z + 1f;
                break;
        }
    }
}
