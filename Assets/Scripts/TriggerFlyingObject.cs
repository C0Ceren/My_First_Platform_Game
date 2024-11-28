using UnityEngine;

public class TriggerFlyingObject : MonoBehaviour
{
    [SerializeField] GameObject Projectile; //Dýþardan bir projectile objesi alýr.
    private void OnTriggerEnter(Collider other)//Bu metod, scriptin eklendiði nesne triggerlandýðýnda çalýþýr. 
    {
        if(other.gameObject.tag == "Player") //Eðer nesneyi triggerlayan nesnenin tagi Player ise çalýþýr.
        {
            Projectile.SetActive(true); //Projectile nesnesini aktif eder.
            Destroy(gameObject); //Daha sonra scripting eklendiði nesneyi yok eder.
        }
    }
}
