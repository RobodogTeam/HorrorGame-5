using UnityEngine;
using UnityEngine.UI;

public class ArtHorrorLooking : MonoBehaviour
{
    [SerializeField]
    private Material emptyImageMaterial;
    [SerializeField]
    private RawImage uiImage;
    [SerializeField]
    private GameObject monster;

    private TriggerScript trigger;
    private MeshRenderer meshRenderer;
    private bool isLookingThisArt;

    void Start()
    {
        trigger = GetComponent<TriggerScript>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        if (trigger.IsTriggered && Input.GetKeyDown(KeyCode.E))
        {
            meshRenderer.material = emptyImageMaterial;
            uiImage.texture = emptyImageMaterial.mainTexture;
            uiImage.gameObject.SetActive(!uiImage.gameObject.activeSelf);
            monster.SetActive(true);
            isLookingThisArt = uiImage.gameObject.activeSelf;
        }
        
        if (!trigger.IsTriggered && uiImage.gameObject.activeSelf && isLookingThisArt)
        {
            uiImage.gameObject.SetActive(false);
            isLookingThisArt = false;
        }
    }
}
