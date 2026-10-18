using Unity.Mathematics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float moveY;
    public Vector2 moveInput;

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveY = Input.GetAxisRaw("Vertical");
        
        moveInput = new Vector2(0, moveY).normalized;

        rb.MovePosition(rb.position + moveInput * speed * Time.deltaTime);
    }
}
