using UnityEngine;
using System;

public class DaySystem : MonoBehaviour
{
    public int day = 1, maxDay = 7;
    public event Action onDayChanged;

    void Start()
    {
        Debug.Log("Game started!");
        Debug.Log("Day " + day);
        onDayChanged?.Invoke();
    }

    public void NextDay()
    {
        day++;
        Debug.Log("Day " + day);
        onDayChanged?.Invoke();

        if (day == maxDay)
            Debug.Log("Enemy is coming!");
    }
}
