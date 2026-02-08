using UnityEngine;

public class MHS_Dropper : MonoBehaviour
{
    [SerializeField]int timeToDrop = 2;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        

    }

    void Update()
    {
        
        if(Time.time >= timeToDrop)
        {
            myMeshRenderer.enabled = false;
            myRigidbody.useGravity = true;
            // Debug.Log("DROP");
        }
    }
}
