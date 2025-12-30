using UnityEngine;

public class GameUI : MonoBehaviour
{
    public DaySystem daySystem;
    public Player player;

    public void Start()
    {
        //player = FindAnyObjectByType<Player>();
        //daySystem = FindAnyObjectByType<DaySystem>();
    }
    public void Train()
    {
        if (daySystem.day == daySystem.maxDay)
        {
            Debug.Log("Enemy phase!");
            return;
        }
        player.attack += 10;
        player.stamina -= 10;
        Debug.Log("Trained!");
        daySystem.NextDay();
    }
}
