using UnityEngine;

public class ParkourBlock : MonoBehaviour
{
    private float offTime, onTime;
    private float timer;
    private bool isOn;
    private ParkourHorrorScript mainScript;
    private Outline outline;

    private void Awake()
    {
        outline = GetComponent<Outline>();
        offTime = Random.Range(0.5f, 1.5f);
        onTime = Random.Range(0.5f, 1.5f);
    }

    private void FixedUpdate()
    {
        if (!mainScript.isPlaying)
            return;

        timer += Time.deltaTime;
        outline.enabled = isOn;
        if (isOn)
        {
            if (timer >= onTime)
            {
                isOn = false;
                timer = 0;
            }
        }
        else
        {
            if (timer >= offTime)
            {
                isOn = true;
                timer = 0;
            }
        }
    }

    public void SetMainScript(ParkourHorrorScript script)
    {
        mainScript = script;
    }
}
