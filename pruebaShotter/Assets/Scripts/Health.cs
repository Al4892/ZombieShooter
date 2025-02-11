using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int _maxHealth=3;
    private int _currentHealth;
    public int currenthealth
    {
        get{return _currentHealth;}
    }
    [SerializeField]
    private UnityEvent _onDie;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _currentHealth=_maxHealth;
    }
    public void TakeDamage(int damage)
    {
        _currentHealth-= damage;
        if(_currentHealth<=0)
        {
            Die();
        }
    }
 private void Die()
 {
    _onDie?.Invoke();
    
 }

    // Update is called once per frame
    void Update()
    {
        
    }
}
