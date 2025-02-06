using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;


public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
private Transform _bulletPivot;
    [SerializeField]
private Animator _WeaponAnimator;
    [SerializeField]
private int _MaxBulletNumber=20;
    [SerializeField]
private int _CartridgeBulletNumber= 5 ;
private int _CurrentbulletNumber=0;
private int _TotalBulletsNumber=0;
private Text _BulletText;
private GetWeapon _getWeapon;
    public void shoot()
    {
        if(_CurrentbulletNumber==0)
        {
            if(_TotalBulletsNumber==0)
            {
                RemoveWeapon();

            }

            return;

        }
        _WeaponAnimator.Play("Shooots",-1,0f);
        GameObject.Instantiate(_bullet,_bulletPivot.position,_bulletPivot.rotation);
        _CurrentbulletNumber--;
        UpdateBulletText();

    }
    private void RemoveWeapon()
    {
        _getWeapon.RemoveWeapon();
        _getWeapon=null;
    }
    public void PickupWeapon(GetWeapon getWeapon)
    {
        _getWeapon=getWeapon;
        _TotalBulletsNumber =_MaxBulletNumber;
        Reload();
        _WeaponAnimator.Play("GetWeapon");
        UpdateBulletText();
       
    }
    public void Reload()
    {
        if(_CurrentbulletNumber == _CartridgeBulletNumber || _TotalBulletsNumber == 0)
        {
            return;
        }
         int bulletsNeeded=_CartridgeBulletNumber-_CurrentbulletNumber;
        if(_TotalBulletsNumber >= _CartridgeBulletNumber)
        {
            _CurrentbulletNumber = bulletsNeeded;
        }
        else if(_TotalBulletsNumber > 0)
        {
            _CurrentbulletNumber = _TotalBulletsNumber;


        }
        _TotalBulletsNumber -= _CurrentbulletNumber;
        UpdateBulletText();
        _WeaponAnimator.Play("Reload");

    }
    private void UpdateBulletText()
    {
        if(_BulletText==null)
        {
            _BulletText=_getWeapon.GetComponent<UiController>().BulletsText;
            
        }
        _BulletText.text= _CurrentbulletNumber+ " / "+ _TotalBulletsNumber;
    }

   
}
