using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player; //pozisyon bilgisi alýnacak oyuncu dýþardan alýnýr
    [SerializeField] float speed; //Nesnenin hareket edeceði hýz dýþardan alýnýr
    Vector3 playerPosition; //Oyuncunun pozisyon bilgisini tutacak vektör.
    void Start()
    {
        playerPosition = player.transform.position; //Oyuncunun pozisyon bilgisi alýnýr.
    }

   
    void Update() //Aþaðýdaki metodlarý çalýþtýrýr.
    {
        MoveAtPlayer();
        DestroyWhenReached();
    }

    void MoveAtPlayer()//scripting eklendiði nesneyi istenilen hýzda oyuncunun olduðu yere doðru hareket ettirir.
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
    
    void DestroyWhenReached()//scriptin eklendiði nesneyi, nesne hedef istikamete ulaþtýðýnda yok eder.
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
