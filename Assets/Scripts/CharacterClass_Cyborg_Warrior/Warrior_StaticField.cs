using UnityEngine;
using System.Collections;

public class Warrior_StaticField : MonoBehaviour
{
    CharacterClass_Cyborg_Warrior WarriorReference;
    private bool Activating = true;

    void Awake()
    {
        WarriorReference = gameObject.GetComponent<CharacterClass_Cyborg_Warrior>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
