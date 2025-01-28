using Unity.Mathematics;
using UnityEngine;

public class GetWeapon : MonoBehaviour
{
    private Gun _weapon;
    public Gun Weapon
    {
        get{return _weapon;}

    }
    [SerializeField]
    private Transform _GunPivot;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Guns")&&_weapon==null)
        {
            GrabWeapon(other.transform);
        }
     
       
    }
    private void GrabWeapon(Transform Weapon)
    {
        Weapon.GetComponent<Rotate>().IsRotatting=false;
        Weapon.GetComponent<BoxCollider>().enabled=false;
        Weapon.SetParent(_GunPivot);
        Weapon.localPosition=Vector3.zero;
        Weapon.localRotation=quaternion.identity;
        _weapon= Weapon.GetComponent<Gun>();
       


    }
}
