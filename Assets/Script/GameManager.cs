using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int life = 3;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    public GameObject gameOverText;
    public GameObject restartButton;

    void Start()
    {
        UpdateUI();
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    public void AddScore()
    {
        score++;
        UpdateUI();
    }

    public void LoseLife()
    {
        life--;
        UpdateUI();
        if (life <= 0)
        {
            GameOver();
        }
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        lifeText.text = "Life: " + life;
    }

    void GameOver()
    {
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
