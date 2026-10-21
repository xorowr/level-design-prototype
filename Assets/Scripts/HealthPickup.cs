using UnityEngine;

public class HealthPickup : MonoBehaviour
{

    public GameObject changeHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (changeHealth.GetComponent<Health>().health < 100)
            {
                    changeHealth.GetComponent<Health>().health += 20;
                if (changeHealth.GetComponent<Health>().health > 100)
                {
                    changeHealth.GetComponent<Health>().health = 100;
                }
                    Destroy(gameObject);
            }


        }
    }
}
