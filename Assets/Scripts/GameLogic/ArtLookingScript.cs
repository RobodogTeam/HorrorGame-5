using UnityEngine;
using UnityEngine.UI;

public class ArtLookingScript : MonoBehaviour
{
    [SerializeField]
    private Texture image;
    [SerializeField]
    private RawImage uiImage;

    private ColliderScript trigger;

    void Start()
    {
        trigger = GetComponent<ColliderScript>();
    }

    private void FixedUpdate()
    {
        if (trigger.isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            uiImage.texture = image;
            uiImage.gameObject.SetActive(!uiImage.gameObject.activeSelf);
        }

        if (!trigger.isTriggered && uiImage.gameObject.activeSelf && uiImage.texture == image)
        {
            uiImage.gameObject.SetActive(false);
        }
    }
}
