using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using static UnityEngine.GraphicsBuffer;

public class Weapon : MonoBehaviour
{
    [SerializeField] public int GunDamage = 15;
    public Camera WeaponCamera;

    public GameObject WeaponHandler;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WeaponCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        WeaponHandler ammoUpdate = WeaponHandler.GetComponent<WeaponHandler>();
        if (ammoUpdate.AmmoAmount > 0)
        {
         
            Shoot();

        }
    }

    public void Shoot()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            WeaponHandler ammoUpdate = WeaponHandler.GetComponent<WeaponHandler>();
            ammoUpdate.AmmoAmount -= 1;
            RaycastHit hit;
            if (Physics.Raycast(WeaponCamera.transform.position, WeaponCamera.transform.forward, out hit))
            {
                Health hitHealth = hit.transform.parent.GetComponent<Health>();
                if (hitHealth != null)
                {
                    hitHealth.Damage(20);
                }

            }

        }
    }





}
