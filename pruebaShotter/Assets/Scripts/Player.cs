
using UnityEngine;
using UnityEngine.Audio;




public class Player : MonoBehaviour
{
    private Health _health;
    private UiController _uiController;
    private bool _isPlaying=true;
    private Enemy _enemy;
    public int Cantidad;
    [SerializeField]
 private GameObject _win;
    
    void Start()
    {
        _health=GetComponent<Health>();
        _uiController=GetComponent<UiController>();
        SoundManager.instance.PlayMusic("Skyrim");
    }
     private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy")&& _isPlaying)
        {
            _health.TakeDamage(1);
            Vector3 pushDirection=(transform.position - collision.transform.position).normalized;
            transform.position+=pushDirection*0.5f;
        }
         else if(collision.gameObject.CompareTag("Key"))
        {
            _isPlaying=false;
            
            _uiController.ShowGameWinUI(true);

        }
    }
    public void Die()
    {
        _uiController.ShowGameOverUI(true);
        SoundManager.instance.Play("Sonicx");
                    
    }
    public void win()
    {
        _uiController.ShowGameWinUI(true);
    }
    

    // Update is called once per frame
    void Update()
    {
       Cantidad = GameObject.FindGameObjectsWithTag("Enemy").Length;
       if(Cantidad<=0)
       {
        _win.SetActive(true);
       }
    }
}
