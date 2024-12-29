using UnityEngine;
using UnityEngine.UI;

public class ArtLookingScript : MonoBehaviour
{
    [SerializeField]
    private Texture image;
    [SerializeField]
    private RawImage uiImage;

    private TriggerScript trigger;
    private bool isLookingThisArt;

    void Start()
    {
        trigger = GetComponent<TriggerScript>();
    }

    private void FixedUpdate()
    {
        if (trigger.IsTriggered && Input.GetKeyDown(KeyCode.E))
        {
            uiImage.texture = image;
            uiImage.gameObject.SetActive(!uiImage.gameObject.activeSelf);
            isLookingThisArt = uiImage.gameObject.activeSelf;
        }

        if (!trigger.IsTriggered && uiImage.gameObject.activeSelf && isLookingThisArt)
        {
            uiImage.gameObject.SetActive(false);
            isLookingThisArt = false;
        }
    }
}