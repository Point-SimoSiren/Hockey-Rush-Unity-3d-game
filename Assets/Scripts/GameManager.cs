using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public float restartDelay = 2f;
    bool GameHasEnded = false;

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void NextLevel3()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void GameCompleted()
    {
        SceneManager.LoadScene("EndScreen");
    }

}
