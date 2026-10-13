using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public Transform WeaponAnchor;
    public Camera MainCam;

    private Weapon EquippedWeapon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Equip(Weapon weapon)
    {
        EquippedWeapon = weapon;
        weapon.transform.parent = WeaponAnchor;
        weapon.transform.position = WeaponAnchor.position;
        weapon.transform.rotation = WeaponAnchor.rotation;
        weapon.WeaponCamera = MainCam;

    }

}
