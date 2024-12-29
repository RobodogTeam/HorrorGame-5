using UnityEngine;

public class ParkourHorrorMonster : MonoBehaviour
{
    [SerializeField]
    private MonsterTrigger monsterTrigger;

    private int lightTime = 2;
    private float timer;
    private bool isLightning;
    private Outline outline;

    private void Awake()
    {
        outline = GetComponent<Outline>();
        monsterTrigger.SetMonster(this);
        gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        outline.enabled = isLightning;
        if (isLightning)
        {
            timer += Time.deltaTime;
            if (timer >= lightTime)
            {
                isLightning = false;
                gameObject.SetActive(false);
            }
        }
    }

    public void StartLightning()
    {
        isLightning = true;
    }
}
