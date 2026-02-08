using UnityEngine;

public class MHS_ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        MeshRenderer meshRendererComponent = GetComponent<MeshRenderer>();
        if (other.gameObject.CompareTag("Player"))
        {
            meshRendererComponent.material.color = Color.black;
            meshRendererComponent.tag = "Hit";
            Debug.Log("Collision");
        }
    }
}
