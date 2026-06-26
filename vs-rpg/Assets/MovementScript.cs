using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    // Using default actions to move player character, see https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/QuickStartGuide.html
    //InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector2 moveValue;

    // Canmove flag is necessary as the fixedupdate will reset the player velocity automatically
    // This can interrupt dash mechanics for example 
    public bool canMove = true;

    private InputAction moveAction;
    private Rigidbody2D rb;


    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveValue = moveAction.ReadValue<Vector2>();
        //movement = new (moveValue.x, moveValue.y, 0f);
        //transform.position +=  moveSpeed * Time.deltaTime * movement;
    }

    void FixedUpdate()
    {
        if (canMove)
        {
        rb.linearVelocity = moveValue * moveSpeed;   
        }
    }

}
