using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag("Player") && collision.gameObject.CompareTag("Enemy"))
        {
            health -= 5;
            Debug.Log(health);
        }
    }
}
