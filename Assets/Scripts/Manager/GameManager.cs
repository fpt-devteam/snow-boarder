using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private bool isGameOver = false;
    private bool isPaused = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        isGameOver = false;
        isPaused = false;

        Time.timeScale = 1f;
        Debug.Log("Game Started");
    }

    public void PauseGame()
    {
        if (isGameOver) return;

        isPaused = true;
        Time.timeScale = 0f;
        Debug.Log("Game Paused");
    }

    public void ResumeGame()
    {
        if (isGameOver) return;

        isPaused = false;
        Time.timeScale = 1f;
        Debug.Log("Game Resumed");
    }

    public void EndGame()
    {
        // if (isGameOver) return;

        // isGameOver = true;
        // Time.timeScale = 0f;
        // Debug.Log("Game Over");

        // GameOverUI gameOverUI = FindAnyObjectByType<GameOverUI>();
        // if (gameOverUI != null)
        // {
        //     gameOverUI.ShowGameOver();
        // }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneLoader.ReloadCurrentScene();
        Debug.Log("Game Restarted");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public bool IsGameOver => isGameOver;
    public bool IsPaused => isPaused;
}
