using UnityEngine;

public class PlayerMover : MonoBehaviour
{
      //Oyuncuyu hareket ettiren Script;
    [SerializeField] float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
       float xvalue = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
       float zvalue = Input.GetAxis("Vertical")*Time.deltaTime*speed;

        transform.Translate(xvalue, 0f, zvalue);
    }
}
