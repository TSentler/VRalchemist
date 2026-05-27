using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public float timeLeft = 60f;

    bool timerActive = true;

    public Text timerText;

    void Update()
    {
        if (!timerActive) return;

        timeLeft -= Time.deltaTime;

        int time = Mathf.CeilToInt(timeLeft);

        timerText.text = "Время: " + time;

        if (time <= 0)
        {
            timerText.text = "Time: 0";
            timerActive = false;
            Debug.Log("Время вышло!");
        }
    }
}