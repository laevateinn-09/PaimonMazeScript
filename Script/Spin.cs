using UnityEngine;

class Spin : MonoBehaviour
{
    public float RotationSpeed = 1f;


    private void Update()
    {
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);        
    }
}
