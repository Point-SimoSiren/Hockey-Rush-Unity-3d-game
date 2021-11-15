using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public int health = 100;
    public int healthLossOnHit = 17;
    public Text healthText;
    
    void Start()
    {
        healthText.text = "Health: " + health.ToString();
        healthText.color = Color.black;
    }
    

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            health = health - healthLossOnHit;
            healthText.text = "Health: " + health.ToString();

            if (health < 30)
            {
                healthText.color = Color.red;
            }

            if (health < 1)
            {
                movement.enabled = false;
                healthText.text = "Restarting level";

                FindObjectOfType<GameManager>().EndGame();
            }

        }
    }

        void OnTriggerEnter(Collider trigger) {
            // If we reach the goal in the end of level
            if (trigger.name == "EndLevel1")
            {
                FindObjectOfType<GameManager>().NextLevel2();
            }

        if (trigger.name == "EndLevel2")
        {
            FindObjectOfType<GameManager>().NextLevel3();
        }

        if (trigger.name == "EndGame")
        {
            Debug.Log("trigger entered in collision script");
            FindObjectOfType<GameManager>().GameCompleted();
        }

    }

}
