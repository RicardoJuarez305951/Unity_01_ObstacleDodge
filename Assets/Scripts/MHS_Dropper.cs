using UnityEngine;

public class MHS_Dropper : MonoBehaviour
{
    [SerializeField]int timeToDrop = 2;
    
    void Start()
    {
        
    }

    void Update()
    {
        
        if(Time.time >= timeToDrop)
        {
            Debug.Log("DROP");
        }
    }
}
