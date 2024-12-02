using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour
{
    public static Player instance;
    private List<Task> tasks = new();
    private FirstPersonController controller;

    private void Awake()
    {
        instance = this;
        controller = GetComponent<FirstPersonController>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    public void StartTask(Task task)
    {
        tasks.Add(task);
        Debug.Log("Кол-во заданий у игрока:" + tasks.Count);
        foreach (var t in tasks)
        {
            Debug.Log(t.Name);
        }
    }

    public void FinishTask(Task task)
    {
        tasks.Remove(task);
    }

    public void TurnOffMoves()
    {
        controller.TurnOffMoves();
    }

    public void TurnOnMoves()
    {
        controller.TurnOnMoves();
    }
}
