using UnityEditor.AnimatedValues;
using UnityEngine;

public class TriggerPlatforms : MonoBehaviour
{
    [SerializeField] private bool MovePlatform = false;
    [SerializeField] private Animator AnimPlatform = null;
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
            if (MovePlatform)
            {
                AnimPlatform.Play("PlatformMoveView", 0, 0.0f);
                gameObject.SetActive(false);


            }
        }




    }
}
