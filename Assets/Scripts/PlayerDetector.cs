using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    [SerializeField] private GameObject enemyAI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AIChase aiChase = enemyAI.GetComponent<AIChase>();
            if (aiChase != null)
            {
                aiChase.target = other.gameObject;
            }
        }
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
