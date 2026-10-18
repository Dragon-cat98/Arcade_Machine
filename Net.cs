using UnityEngine;

public class Net : MonoBehaviour
{
    BallScripts ballScripts;
    GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballScripts = Object.FindAnyObjectByType<BallScripts>();
        gameManager = Object.FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            //add 1 Point to the person who scored
            ballScripts.transform.position = new Vector2(0, 0);
            StopAllCoroutines();
            
            ballScripts.launchBall();
            Debug.LogWarning("point added");

            if (gameObject.CompareTag("net_P1"))
            {
                gameManager.AddPoint_P2();
            }
            else
            {
                gameManager.AddPoint_P1();
            }

        }
    }
}
