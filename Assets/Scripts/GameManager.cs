using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public AudioSource soundCook;

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore()
    {
        score += 10;
        Debug.Log("Очки: " + score);
        UpdateScoreUI();
        soundCook.Play();
    }

    public void RemoveScore()
    {
        score -= 5;
        Debug.Log("Очки: " + score);
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}