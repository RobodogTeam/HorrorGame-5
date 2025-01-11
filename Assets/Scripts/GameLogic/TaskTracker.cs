using System.Collections.Generic;
using UnityEngine;

public class TaskTracker : MonoBehaviour
{
    public GameObject ParkourTask;
    public GameObject PanicRoomTask;
    public GameObject GalleryTask;
    public GameObject CarouselTask;
    public GameObject MetroTask;
    public GameObject LabirintTask;

    public bool IsReadyForLabirint =>
        !ParkourTask.activeSelf && !PanicRoomTask.activeSelf && !GalleryTask.activeSelf 
        && !CarouselTask.activeSelf && !MetroTask.activeSelf && !LabirintTask.activeSelf;

    void Update()
    {
        if (IsReadyForLabirint)
        {
            LabirintTask.SetActive(true);
        }
    }
}