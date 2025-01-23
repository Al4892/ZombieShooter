using UnityEngine;

public class Rotate : MonoBehaviour
{

[SerializeField]
 private float _rotateSpeed= 0;
[SerializeField]
private float _RotateUpdown=0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f,_rotateSpeed+ Time.deltaTime,0f);

        gameObject.transform.Rotate(_RotateUpdown+Time.deltaTime,0f,0f);
        new WaitForSeconds(2f);
        gameObject.transform.Rotate(_RotateUpdown-Time.deltaTime,0f,0f);
        new WaitForSeconds(2f);


        
    }
}
