using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Late update used so that the camera moves after the player moves and not before.
    void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
    }
}
