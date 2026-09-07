using Unity.VisualScripting;
using UnityEngine;

public class Tuong : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Dead");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Va cham");
    }
}
