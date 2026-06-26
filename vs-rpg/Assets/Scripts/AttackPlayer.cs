using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        direction = (playerRb.position - rb.position).normalized;
        Vector2 newPosition = rb.position +  moveSpeed * Time.fixedDeltaTime * direction; 
        rb.MovePosition(newPosition);
    }
}
