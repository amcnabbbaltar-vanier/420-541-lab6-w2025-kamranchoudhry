using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    public void Start()
    {
        gameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            scoreText.text = "Score: " + GameManager.Instance.targetScore.ToString();
        }

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
