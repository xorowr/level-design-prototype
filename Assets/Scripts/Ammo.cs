using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class Ammo : MonoBehaviour
{

    public GameObject WeaponHandler;

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
            WeaponHandler ammoUpdate = WeaponHandler.GetComponent<WeaponHandler>();
            if (ammoUpdate != null)
                {
                ammoUpdate.AmmoAmount += 10;
                Destroy(gameObject);
                }

        }
    }


}
