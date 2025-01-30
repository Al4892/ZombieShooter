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
    public void shoot()
    {
        _WeaponAnimator.Play("Shooots",-1,0f);
        GameObject.Instantiate(_bullet,_bulletPivot.position,_bulletPivot.rotation);
        _CurrentbulletNumber--;
        UpdateBulletText();

    }
    public void PickupWeapon()
    {
        _TotalBulletsNumber =_MaxBulletNumber;
        //_CurrentbulletNumber= _CartridgeBulletNumber;
        Reload();
        _WeaponAnimator.Play("GetWeapon");
       
    }
    public void Reload()
    {
        if(_TotalBulletsNumber >= _CartridgeBulletNumber)
        {
            _CurrentbulletNumber = _CartridgeBulletNumber;
        }
        else if(_TotalBulletsNumber > 0)
        {
            _CurrentbulletNumber = _TotalBulletsNumber;


        }
        _TotalBulletsNumber -= _CurrentbulletNumber;
        UpdateBulletText();

    }
    private void UpdateBulletText()
    {
        if(_BulletText==null)
        {
            _BulletText=GameObject.Find("BulletsText").GetComponent<Text>();
            
        }
        _BulletText.text= _CurrentbulletNumber+ " / "+ _TotalBulletsNumber;
    }

   
}
