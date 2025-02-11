using Unity.VisualScripting;
using UnityEngine;

public class BUllet : MonoBehaviour
{
    private Rigidbody _riggidboddy;
   [SerializeField]
   private float _bulletSpeed;

   [SerializeField]
   private int _damage;
   public int damage
   {
      get {return _damage;}
   }

   private void OnEnable()
   {
     if(_riggidboddy==null)
     {
        _riggidboddy=gameObject.GetComponent<Rigidbody>();
     }
      _riggidboddy.AddForce(transform.forward*_bulletSpeed,ForceMode.Impulse);
     

   } 
}
