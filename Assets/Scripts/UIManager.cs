using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject playerInfo;
    public Text HealthText;
    public float HealthDisplay;
    private Health currentHealth;

    public Text AmmoText;
    public float AmmoDisplay;
    private WeaponHandler currentAmmo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = playerInfo.GetComponent<Health>();
        currentAmmo = playerInfo.GetComponent<WeaponHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInfo != null)
        {
            HealthDisplay = currentHealth.health;
            HealthText.text = "Health: " + (HealthDisplay);
        }

        if (playerInfo != null)
        {
            AmmoDisplay = currentAmmo.AmmoAmount;
            AmmoText.text = "Ammo: " + (AmmoDisplay);
        }

    }



}
