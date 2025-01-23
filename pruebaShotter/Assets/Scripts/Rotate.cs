using System;
using UnityEngine;

public class Rotate : MonoBehaviour
{

[SerializeField]
 private float _rotateSpeed= 0;
[SerializeField]
private bool _isRotatting=true;

 public bool IsRotatting
 {
    get{return _isRotatting;}
    set{_isRotatting= value;}
 }
       void Update()
    {
        
       Rotates();


        
    }
    private void Rotates()
    {
        if(_isRotatting)
        {
            gameObject.transform.Rotate(0f,_rotateSpeed+ Time.deltaTime,0f);
        }
    }
}
