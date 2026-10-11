using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class TriggerDoor : MonoBehaviour
{

    [SerializeField] private bool OpenDoor = false;
    [SerializeField] private Animator animDoor = null;

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
            if (OpenDoor)
            {
                animDoor.Play("DoorOpen", 0, 0.0f);
                gameObject.SetActive(false);


            }
        }




    }
}
