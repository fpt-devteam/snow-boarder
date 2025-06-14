using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{

    public void OnHomePress()
    {
        Debug.Log("Home button pressed. Returning to main menu...");
        SceneManager.LoadScene("MainMenu");
    }

    public void OnGameExitPress()
    {
        Debug.Log("Exit button pressed. Exiting game...");
        Application.Quit();
    }
}
