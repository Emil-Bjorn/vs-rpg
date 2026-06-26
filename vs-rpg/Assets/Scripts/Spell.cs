using UnityEngine;

public class Spell : ScriptableObject
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        public string SpellName;
        public float cooldownTime;
        public float activeTime;

        public virtual void Activate(GameObject parent){}

}
