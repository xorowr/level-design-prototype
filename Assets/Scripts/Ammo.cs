using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class Ammo : MonoBehaviour
{


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
                //changeAmmo.GetComponent<Weapon>().AmmoAmount += 10;
                Weapon liveWeaponClone = other.GetComponentInChildren<Weapon>();
                if (liveWeaponClone != null)
                {
                    liveWeaponClone.AmmoAmount += 10;
                    Destroy(gameObject);
                }

        }
    }


}
