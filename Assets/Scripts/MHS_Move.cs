using UnityEngine;

public class MHS_Mover : MonoBehaviour
{
    float xValue = 0F;
    float yValue = 0F;
    float zValue = 0F;
    [SerializeField]float moveSpeed = 5F;

    void MoveCharacter()
    {
        xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
        transform.Translate(xValue,yValue,zValue);        
    }
}
