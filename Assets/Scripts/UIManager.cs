using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject healthLocation;
    public Text HealthText;
    public float HealthDisplay;
    private Health currentHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = healthLocation.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthLocation != null)
        {
            HealthDisplay = currentHealth.health;
            HealthText.text = "Health: " + (HealthDisplay);
        }

    }



}
