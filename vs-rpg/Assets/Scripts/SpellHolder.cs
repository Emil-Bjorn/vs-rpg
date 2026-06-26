using System.Configuration.Assemblies;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellHolder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Spell spell;
    public KeyCode key;
    float cooldownTime;
    float activeTime;

    enum SpellState
    {
        ready,
        active,
        cooldown
    }

    SpellState state = SpellState.ready;

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case SpellState.ready:
                if (Keyboard.current.qKey.wasPressedThisFrame)
                {
                    spell.Activate(gameObject);
                    state = SpellState.active;
                    activeTime = spell.activeTime;
                }
            break;
            case SpellState.active:
                if (activeTime > 0)
                {
                    activeTime -= Time.deltaTime;
                }
                else
                {
                    GetComponent<MovementScript>().canMove = true;
                    state = SpellState.cooldown;
                    cooldownTime = spell.cooldownTime;
                }
            break;
            case SpellState.cooldown:
                if (cooldownTime > 0)
                {
                    cooldownTime -= Time.deltaTime;
                }
                else
                {
                    state = SpellState.ready;
                }
            break;
        }

    }
}
