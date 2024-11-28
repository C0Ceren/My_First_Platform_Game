using UnityEngine;

public class Drop : MonoBehaviour
{     
    //nesne triggerland�ktan sonra d��ardan verilen drops nesnelerini aktif eder.

    [SerializeField] GameObject[] Drops;  //Drop nesnelerini liste halinde d��ardan al�yoruz.
    

    private void OnTriggerEnter(Collider other)
    {    if (other.gameObject.tag == "Player") //nesneyi tetikleyen objenin tagi Player ise a�a��daki ad�mlar� izler
        {
            for (int i = 0; i < Drops.Length; i++)//bu dizi Drop listesinin uzunlu�u kadar devam eder
            {
                Drops[i].SetActive(true); //Her bir drop nesnesinin setactive �zelli�ini true yapar.
            }
        }
    }
}
