using UnityEngine;

public class WeaponCollectable : MonoBehaviour
{
    public Weapon WeaponPrefab;
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
        if(other.CompareTag("Player"))
        {
            WeaponHandler WeaponHandler = other.GetComponent<WeaponHandler>();
            if(WeaponHandler != null)
            {
                Weapon Weapon = GameObject.Instantiate(WeaponPrefab);
                WeaponHandler.Equip(Weapon);

                Destroy(gameObject);
            }
        }
    }
}
