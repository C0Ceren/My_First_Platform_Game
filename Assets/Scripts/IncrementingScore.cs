using TMPro;
using UnityEngine;

public class IncrementingScore : MonoBehaviour
{   
    //Oyuncunun puan�n� tagi "Hit" olan bir nesneye �arpt���nda birer birer d���r�r, puan� ekrana yazd�r�r.

    [SerializeField] TMP_Text ScoreBoardText; //Puan�n yazd�r�laca�� Text
    [SerializeField] int score; //Ba�lang�� puan� d��ardan al�n�r.
    void Start()
    {
        
    }

  
    void Update()
    {
        ScoreBoardText.text = score.ToString();//Puan� ekrana yazd�r�r
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Hit") //Oyuncu, Hit tagli nesneye �arpt���nda puan� 1 azal�r.
        {
            score = score - 1;
        }
    }
}
