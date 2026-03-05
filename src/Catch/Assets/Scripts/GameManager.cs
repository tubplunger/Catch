using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Score")]
    public int score = 0;
    public TextMeshProUGUI scoreText;

    [Header("Misses")]
    public int maxMisses = 10;
    private int currentMisses;
    public TextMeshProUGUI missesText;

    [Header("Game Over")]
    public GameObject gameOverPanel;
    public BallSpawner spawner;
    public PlayerMovement player;

    private bool isGameOver = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        currentMisses = maxMisses;
        UpdateScoreUI();
        UpdateMissUI();
        gameOverPanel.SetActive(false);
    }

    public void AddScore(int amount)
    {
        if (isGameOver) return;

        score += amount;
        UpdateScoreUI();
    }

    public void MissedBall()
    {
        if (isGameOver) return;

        currentMisses--;
        UpdateMissUI();

        if (currentMisses <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        isGameOver = true;

        spawner.StopSpawning();

        player.enabled = false;

        Rigidbody rb = player.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        gameOverPanel.SetActive(true);
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    void UpdateMissUI()
    {
        missesText.text = "Misses: " + currentMisses;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");

#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
