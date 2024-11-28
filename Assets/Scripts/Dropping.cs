using UnityEngine;

public class Dropping : MonoBehaviour
{
    
   

    [SerializeField] float timeToWait = 1f;
    void Start() //Oyunun ba��nda oyun nesnesinin yer �ekimini ve meshrendererini kapat�p g�r�nmeyip d��memesini sa�lar.
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

   
    void Update() //Cisim OYUN ���NDE AKT�F OLDUKTAN istenilen s�re kadar sonra mesh renderini ve yer �ekimini geri a�ar.
    {
        if(Time.time > timeToWait)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject .GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
