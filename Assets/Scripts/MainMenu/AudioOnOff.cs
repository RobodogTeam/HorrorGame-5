using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Sprite audioOn;
    public Sprite audioOff;
    public GameObject buttonAudio;

    public Slider slider;
    public float oldVolume;

    public AudioClip clip;
    public AudioSource audio;

    public void Start()
    {
        oldVolume = slider.value;
        if(!PlayerPrefs.HasKey("volume")) slider.value = 1;
        if(!PlayerPrefs.HasKey("volume")) audio.volume = 1;
    }

    void Update()  
    {
        if(oldVolume != slider.value)
        {
            PlayerPrefs.SetFloat("volume", slider.value);
            PlayerPrefs.Save();
            oldVolume = slider.value;
        }
        audio.volume = slider.value;
        audio.volume = PlayerPrefs.GetFloat("volume");
    }

    public void OnOffAudio()
    {
        if(AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            buttonAudio.GetComponent<Image>().sprite = audioOff;
        }
        else
        {
            AudioListener.volume = 1;
            buttonAudio.GetComponent<Image>().sprite = audioOn;
        }
    }
    public void PlaySound()
    {
        audio.PlayOneShot(clip);
    }
}