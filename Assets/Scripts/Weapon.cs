using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using static UnityEngine.GraphicsBuffer;

public class Weapon : MonoBehaviour
{
    [SerializeField] public int GunDamage = 15;
    [SerializeField] public int AmmoAmount = 15;
    private Camera WeaponCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WeaponCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            AmmoAmount -= 1;

            RaycastHit hit;
            if (Physics.Raycast(WeaponCamera.transform.position, WeaponCamera.transform.forward, out hit))
            {
                Health hitHealth = hit.transform.parent.GetComponent<Health>();
                if (hitHealth != null && AmmoAmount > 0)
                {
                    hitHealth.Damage(20);
                }

            }

        }
    }

}
