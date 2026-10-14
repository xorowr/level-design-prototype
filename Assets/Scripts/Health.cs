using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public TextMeshProUGUI UIText;
    [SerializeField] public float maxHealth = 100;

    [SerializeField] public float health;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        health = maxHealth;
        UIText.text = "Health: " + health.ToString();
    }

    public void Damage(float amount)
    {
        health -= amount;
        UIText.text = "Health: " + health.ToString();
        if (health <= 0)
        {
            Die();
        }
    }


    private void Die()
    {
        Destroy(gameObject);
    }
}
