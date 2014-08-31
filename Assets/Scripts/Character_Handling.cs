using UnityEngine;
using System.Collections;

public class Character_Handling : MonoBehaviour 
{
    //Stats
    [HideInInspector]
    public int Health;
    [HideInInspector]
    public int Energy;

    public int CurrentHealth;
    public int CurrentEnergy;

    //Regen
    public int HealthRegen;
    private float NextHealthRegen = 0.0f;

    public int EnergyRegen;
    private float NextEnergyRegen = 0.0f;

    //Effects
    public bool Stunned;

    void Awake()
    {

    }

    void Update()
    {
        //Health and Energy Regen over time
        if ((CurrentHealth < Health) && (NextHealthRegen < Time.deltaTime))
        {
            NextHealthRegen = Time.deltaTime + 5f;
            Healing(HealthRegen);
        }
        if ((CurrentEnergy < Energy) && (NextEnergyRegen < Time.deltaTime))
        {
            NextEnergyRegen = Time.deltaTime + 5f;
            EnergyHeal(EnergyRegen);
        }
    }

    public void TakingDamage(int DamageTaken)
    {
        if (CurrentHealth - DamageTaken < 0)
        {
            CurrentHealth = 0;
            Death();
        }
        else
        {
            CurrentHealth = CurrentHealth - DamageTaken;
        }

    }

    public void Healing(int HealingDone)
    {
        if (CurrentHealth + HealingDone > Health)
        {
            CurrentHealth = Health;
        }
        else
        {
            CurrentHealth = CurrentHealth + HealingDone;
        }
    }

    public void EnergyHeal(int EnergyHealing)
    {
        if (CurrentEnergy + EnergyHealing > Energy)
        {
            CurrentEnergy = Energy;
        }
        else
        {
            CurrentEnergy = CurrentEnergy + EnergyHealing;
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
	
}
