using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player; //pozisyon bilgisi al�nacak oyuncu d��ardan al�n�r
    [SerializeField] float speed; //Nesnenin hareket edece�i h�z d��ardan al�n�r
    Vector3 playerPosition; //Oyuncunun pozisyon bilgisini tutacak vekt�r.
    void Start()
    {
        playerPosition = player.transform.position; //Oyuncunun pozisyon bilgisi al�n�r.
    }

   
    void Update() //A�a��daki metodlar� �al��t�r�r.
    {
        MoveAtPlayer();
        DestroyWhenReached();
    }

    void MoveAtPlayer()//scripting eklendi�i nesneyi istenilen h�zda oyuncunun oldu�u yere do�ru hareket ettirir.
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
    
    void DestroyWhenReached()//scriptin eklendi�i nesneyi, nesne hedef istikamete ula�t���nda yok eder.
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
