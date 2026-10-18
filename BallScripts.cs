using System.Collections;
using UnityEngine;

public class BallScripts : MonoBehaviour
{
    Rigidbody2D rb;
    public float Xvelocity;
    public float Yvelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        launchBall();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.otherCollider.CompareTag("boundary_UPDown"))
        {
            launchBall();
        }
    }

    public void launchBall()
    {
        StartCoroutine(AddSpeed(3f));

        float i = Random.Range(0, 2);
        Debug.Log(i);
        if (i == 1)
        {
            Xvelocity = 5f;
        }
        else
        {
            Xvelocity = -5f;
        }

        Yvelocity = Random.Range(5f, 12f);
        rb.linearVelocity = new Vector2(Xvelocity, Yvelocity);
    }

    public IEnumerator AddSpeed(float time)
    {
        yield return new WaitForSeconds(time);
        Yvelocity += 1.1f;
        StartCoroutine(AddSpeed(5f));
    }
}
