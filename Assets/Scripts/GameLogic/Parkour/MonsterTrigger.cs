using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{
    private ParkourHorrorMonster monster;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            monster.gameObject.SetActive(true);
            monster.StartLightning();
        }
    }

    public void SetMonster(ParkourHorrorMonster monster)
    {
        this.monster = monster;
    }
}
