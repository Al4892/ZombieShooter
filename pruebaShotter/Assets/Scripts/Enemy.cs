using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private string _EnemytoLock="Player";
    [SerializeField]
    private float _speed= 1f;
    private Transform _Objective;
    private Health _health;
    
    void Start()
    {
        _Objective=GameObject.FindGameObjectWithTag(_EnemytoLock).transform;
        _health=GetComponent<Health>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            _health.TakeDamage(collision.gameObject.GetComponent<BUllet>().damage);
            Destroy(collision.gameObject);
            SoundManager.instance.Play("Hit");
           

        }
    }
    public void Die()
    {
        Destroy(gameObject);
        SoundManager.instance.Play("Exp");
    }

    // Update is called once per frame
    void Update()
    {
        FollowObjective();
    }
    private void FollowObjective()
    {
        Vector3 direction=(_Objective.position-transform.position).normalized;
        transform.position+=direction * _speed * Time.deltaTime;
        transform.rotation=Quaternion.LookRotation(direction);
    }
}
