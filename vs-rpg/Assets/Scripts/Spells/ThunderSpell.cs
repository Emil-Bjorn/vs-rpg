using UnityEngine;
using UnityEngine.InputSystem;
[CreateAssetMenu(menuName = "Spells/Thunder Spell")]
public class ThunderSpell : Spell

// To change the size of the spell -> Prefab transform scale
// To change the speed of animation -> 
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float damage = 10f;
    public float radius = 1.5f;
    public GameObject thunderPrefab;

    public override void Activate(GameObject parent)
    {
        if (thunderPrefab == null)
        {
            Debug.LogWarning("Thunder prefab is missing.");
            return;
        }

        Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();

        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(
            new Vector3(mouseScreenPosition.x, mouseScreenPosition.y, 0f)
        );

        mouseWorldPosition.z = 0f;

        Instantiate(thunderPrefab, mouseWorldPosition, Quaternion.identity);
    }
}