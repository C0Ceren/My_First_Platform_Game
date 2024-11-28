using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingObstacles : MonoBehaviour
{
      //Sar� silindirleri hareket ettiren script.
    [SerializeField] float speed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(speed, 0f, 0f);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Player")
        {
            speed *= -1;
        } //Cisim oyuncu d���nda bir objeye �arpt���nda ters y�nde hareket etmeye ba�lar
    }
}
