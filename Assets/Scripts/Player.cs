using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour
{
    public int HP;
    public static Player instance;
    private FirstPersonController controller;
    private Transform restartPoint;
    private float restartTimer = 2;
    private bool isDeath;

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
        if (isDeath)
        {
            restartTimer += Time.deltaTime;
        }
    }

    public void SetRestartPoint(Transform point)
    {
        restartPoint = point;
    }

    public void TurnOffMoves()
    {
        controller.TurnOffMoves();
    }

    public void TurnOnMoves()
    {
        controller.TurnOnMoves();
    }

    public void Death()
    {
        isDeath = true;
        if (restartTimer < 1)
            return;

        restartTimer = 0;
        GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
        GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        transform.position = restartPoint.position;
        HP -= 1;
        Debug.Log($"Осталось хп: {HP}");

        GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.None;
        GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Discrete;
    }
}
