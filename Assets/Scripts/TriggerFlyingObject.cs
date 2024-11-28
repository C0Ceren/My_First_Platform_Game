using UnityEngine;

public class TriggerFlyingObject : MonoBehaviour
{
    [SerializeField] GameObject Projectile; //D��ardan bir projectile objesi al�r.
    private void OnTriggerEnter(Collider other)//Bu metod, scriptin eklendi�i nesne triggerland���nda �al���r. 
    {
        if(other.gameObject.tag == "Player") //E�er nesneyi triggerlayan nesnenin tagi Player ise �al���r.
        {
            Projectile.SetActive(true); //Projectile nesnesini aktif eder.
            Destroy(gameObject); //Daha sonra scripting eklendi�i nesneyi yok eder.
        }
    }
}
