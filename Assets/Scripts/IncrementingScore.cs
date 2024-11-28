using TMPro;
using UnityEngine;

public class IncrementingScore : MonoBehaviour
{   
    //Oyuncunun puanýný tagi "Hit" olan bir nesneye çarptýðýnda birer birer düþürür, puaný ekrana yazdýrýr.

    [SerializeField] TMP_Text ScoreBoardText; //Puanýn yazdýrýlacaðý Text
    [SerializeField] int score; //Baþlangýç puaný dýþardan alýnýr.
    void Start()
    {
        
    }

  
    void Update()
    {
        ScoreBoardText.text = score.ToString();//Puaný ekrana yazdýrýr
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Hit") //Oyuncu, Hit tagli nesneye çarptýðýnda puaný 1 azalýr.
        {
            score = score - 1;
        }
    }
}
