using UnityEngine;

public class Opponent : MonoBehaviour
{
    public Vector2 ballVector;
    Rigidbody2D rb;
    public float BallY;
    BallScripts ballScripts;
    public float Cleareance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballScripts = Object.FindAnyObjectByType<BallScripts>();

        randomClearance();
    }

    // Update is called once per frame
    void Update()
    {
        BallY = ballScripts.transform.position.y;
        ballVector = new Vector2(0f, BallY - Cleareance);
        rb.MovePosition(ballVector);
    }

    public void randomClearance()
    {
        Cleareance = Random.Range(0.9f, 1.1f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.otherCollider.CompareTag("Ball"))
        {
            randomClearance();
        }
    }
}
