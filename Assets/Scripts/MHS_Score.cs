using UnityEngine;

public class MHS_Score : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            hits++;
            Debug.Log("You Bumped into this object " + hits );
        }
    }
    void Start()
    {
        
    }

}
