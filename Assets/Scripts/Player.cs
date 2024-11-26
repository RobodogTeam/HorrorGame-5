using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    private List<Task> tasks = new();

    private void Awake()
    {
        instance = this;
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
}
