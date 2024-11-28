using UnityEngine;

public class Dropping : MonoBehaviour
{
    
   

    [SerializeField] float timeToWait = 1f;
    void Start() //Oyunun baþýnda oyun nesnesinin yer çekimini ve meshrendererini kapatýp görünmeyip düþmemesini saðlar.
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

   
    void Update() //Cisim OYUN ÝÇÝNDE AKTÝF OLDUKTAN istenilen süre kadar sonra mesh renderini ve yer çekimini geri açar.
    {
        if(Time.time > timeToWait)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject .GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
