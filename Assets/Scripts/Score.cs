using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    private string sceneName;
    private double startingScore;
    private double actualScore;
    private float update;

    void Start()
    {
        update = 0.0f;

        sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
        {
            case "Scene1":
                startingScore = 0.00;
                break;
            case "Scene2":
                startingScore = 10000.00;
                break;
            case "Scene3":
                startingScore = 20000.00;
                break;
            case "Scene4":
                startingScore = 30000.00;
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {

        update += Time.deltaTime;
        if (update > 1.0f)
        {
            update = 0.0f;
            scoreText.text = "Score: " + (startingScore + player.position.z).ToString("0");

        }
    }
}
