using UnityEngine;
using System.Collections;

public class CharacterClass_Cyborg_Warrior : MonoBehaviour 
{
    //Talent Tree
    public bool RoboticLegOvercharge = false;
    public bool RoboticArmUpgrade = false;
    public bool HyperPunch = false;
    public bool ExplosiveGauntlet = false;
    public bool KineticAugmentor = false;
    public bool LaserSword = false;
    public bool BatteryCharge = false;
    public bool ReinforcedExoskeleton = false;
    public bool EletricityGenerator = false;
    public bool StaticField = false;
    public bool MusleSpasm = false;
    public bool TaserUpgrade = false;
    public bool DeflectorShield = false;
    public bool EnergyDistributor = false;

    //Spell Variables
    //AutoAttack
    private float AutoAttackRate;
    private float NextAutoAttack = 0.0f;
    
    //Robo_Leg
    private float RoboLegCooldown;
    private float NextRoboLeg = 0.0f;

    //Hyper Punch
    private float HyperPunchCooldown;
    private float NextHyperPunch = 0.0f;

    //Static Field
    public GameObject StaticFieldObject;
    private float StaticFieldCooldown;
    private float NextStaticField = 0.0f;

    //Laser Sword
    private float LaserSwordCooldown;
    private float NextLaserSword = 0.0f;

    //Deflector Shield
    private float DeflectorShieldCooldown;
    private float NextDeflectorShield = 0.0f;

    void Awake()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("AutoAttack"))
        {

        }
        if (Input.GetButtonDown("Spell1") && NextRoboLeg < Time.deltaTime)
        {

        }
        if (Input.GetButtonDown("Spell2") && NextStaticField < Time.deltaTime)
        {
            Static_Field();
        }
        if (Input.GetButtonDown("Spell3"))
        {

        }
        if (Input.GetButtonDown("Spell4"))
        {

        }
        if (Input.GetButtonDown("Spell5"))
        {

        }
    }

    //Auto Attack
    void Auto_Attack()
    {

    }

    //Robotic Leg OverCharge
    void Robo_Leg()
    {

    }

    //Hyper Punch
    void Hyper_Punch()
    {

    }

    //Static Field
    void Static_Field()
    {
        NextStaticField = Time.deltaTime + StaticFieldCooldown;
        GameObject Field = Instantiate(StaticFieldObject, transform.position, transform.rotation) as GameObject;
    }

    //LaserSword
    void Laser_Sword()
    {

    }

    //Deflector Shield
    void Deflector_Shield()
    {

    }

}
