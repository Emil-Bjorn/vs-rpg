using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    // Using default actions to move player character, see https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/QuickStartGuide.html
    InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        Vector3 movement = new (moveValue.x, moveValue.y, 0f);
        transform.position +=  moveSpeed * Time.deltaTime * movement;
    }
}
