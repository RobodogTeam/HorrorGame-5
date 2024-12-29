using UnityEngine;

public class LampHorror : MonoBehaviour
{
    private float onTime = 1, offTime = 0.5f;
    private float timer;
    private bool isOn;
    private Light lightning;

    private void Awake()
    {
        lightning = GetComponent<Light>();
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        lightning.enabled = isOn;
        if (isOn)
        {
            if (timer >= onTime)
            {
                isOn = false;
                timer = 0;
                onTime = Random.Range(0.8f, 2);
            }
        }
        else
        {
            if (timer >= offTime)
            {
                isOn = true;
                timer = 0;
                offTime = Random.Range(0.2f, 0.5f);
            }
        }
    }
}
