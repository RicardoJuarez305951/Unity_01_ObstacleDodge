using UnityEngine;

public class MHS_ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        Debug.Log("Collision");
        
    }
}
