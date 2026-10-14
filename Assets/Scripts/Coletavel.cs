using UnityEngine;

public class Coletavel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);    
        }
    }     
}
