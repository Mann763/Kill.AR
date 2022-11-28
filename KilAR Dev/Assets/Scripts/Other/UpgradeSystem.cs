using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class UpgradeSystem : MonoBehaviour
{
    playerHealth Phealth;
    ui_manager ui;
    ProjectileMoveScript pMover;
    WeaponScript weapon;
    Spawner spawn;

    Enemy_Health enemy_;
    

    // Start is called before the first frame update
    void Start()
    {
        Phealth = GetComponent<playerHealth>();
        enemy_ = GetComponent<Enemy_Health>();
        ui = GetComponent<ui_manager>();
        pMover = GetComponent<ProjectileMoveScript>();
        weapon = GetComponent<WeaponScript>();
        spawn = GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Add_Health") && ui.coin >= 350)
        {
            ui.coin =- 350;
            ui.CoinRefresh(ui.coin);

            Phealth.currentHealth = Phealth.maxHealth;
            Phealth.healthBar.SetHealth(Phealth.currentHealth);

            pMover.player_Hit += 2;
        }

        if (CrossPlatformInputManager.GetButtonDown("Add_Damage") && ui.coin >= 350)
        {
            ui.coin = -350;
            ui.CoinRefresh(ui.coin);

            weapon.GiveDamage += 3;
            pMover.player_Hit += 2;
        }

        if (CrossPlatformInputManager.GetButtonUp("Add_Health"))
        {
            ui.upgradeSystem.SetActive(false);
            spawn.nextwave = 0;
        }

        if (CrossPlatformInputManager.GetButtonUp("Add_Damage"))
        {
            ui.upgradeSystem.SetActive(false);
            spawn.nextwave = 0;
        }

        if (CrossPlatformInputManager.GetButtonDown("Skip"))
        {
            ui.upgradeSystem.SetActive(false);
            spawn.nextwave = 0;
        }

    }
}
