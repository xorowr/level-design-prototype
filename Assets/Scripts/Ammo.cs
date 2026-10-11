using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] private float AmmoAmount = 15;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeAmmo(float amount)
    {
        if (AmmoAmount > 0)
        {
            AmmoAmount -= amount;
        }
        else
        {
            Debug.Log("No ammo");
        }
    }

    public void GainAmmo(float amount)
    {
        AmmoAmount += amount;
    }
}
