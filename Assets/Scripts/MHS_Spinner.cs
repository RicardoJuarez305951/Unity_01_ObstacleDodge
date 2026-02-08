using UnityEngine;

public class MHS_Spinner : MonoBehaviour
{
    [SerializeField] float xSpeed = 0.0F;
    [SerializeField] float ySpeed = 0.0F;
    [SerializeField] float zSpeed = 0.0F;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateObject();
    }

    void rotateObject()
    {
        transform.Rotate(xSpeed,ySpeed,zSpeed);
    }
}
