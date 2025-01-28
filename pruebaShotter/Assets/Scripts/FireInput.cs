using UnityEngine;

public class FireInput : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<GetWeapon>().Weapon?.shoot();

        }
    }
}
