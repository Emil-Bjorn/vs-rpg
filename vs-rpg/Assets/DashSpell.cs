using UnityEngine;


[CreateAssetMenu(menuName = "Spells/Dash Spell")]
public class DashSpell : Spell
{
    public float dashVelocity;
    public override void Activate(GameObject parent)
    {
        MovementScript movement = parent.GetComponent<MovementScript>();
        Rigidbody2D rigidbody = parent.GetComponent<Rigidbody2D>();

        movement.canMove = false
        rigidbody.linearVelocity = movement.moveValue.normalized * dashVelocity;
    }
}
