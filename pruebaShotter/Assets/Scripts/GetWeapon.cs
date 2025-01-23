using UnityEngine;

public class GetWeapon : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Guns"))
        {
            other.gameObject.SetActive(false);
        }
        


        
    }
}
