using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask platform;
    Rigidbody2D rb;
    float direction;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckForInput();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(direction, 0f);
    }

    private void CheckForInput()
    {
        direction = Input.acceleration.x * 3;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5F, 7.5F), transform.position.y);
    }
}
