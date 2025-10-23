using UnityEngine;
using UnityEngine.SceneManagement;

public class ScceneManager : MonoBehaviour

{
    public void LoadScene0()
    {
        SceneManager.LoadScene(0);
    }
    public void GameExit()
    {
        Application.Quit();
        Debug.Log("Attempted Quit");
    }
}
