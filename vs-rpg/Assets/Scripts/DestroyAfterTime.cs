using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float lifetime = 1.2f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}