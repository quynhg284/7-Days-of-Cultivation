using UnityEngine;
using TMPro;

public class DayUI : MonoBehaviour
{
    public DaySystem daySystem;
    public TMP_Text dayText;

    void Start()
    {
        daySystem.onDayChanged += UpdateDayText;
        UpdateDayText(); //Show Day 1 when start
    }

    void OnDestroy()
    {
        daySystem.onDayChanged -= UpdateDayText;
    }

    void UpdateDayText()
    {
        if (dayText != null && daySystem != null)
            dayText.text = "Day " + daySystem.day;
    }
}
