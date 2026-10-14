using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI UIText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void UpdateUI()
    {
        Weapon targetAmmo = UIText.GetComponent<Weapon>();
        UIText.text = "Ammo: " + targetAmmo.AmmoAmount.ToString();

    }
}
