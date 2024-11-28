using UnityEngine;

public class Drop : MonoBehaviour
{     
    //nesne triggerlandýktan sonra dýþardan verilen drops nesnelerini aktif eder.

    [SerializeField] GameObject[] Drops;  //Drop nesnelerini liste halinde dýþardan alýyoruz.
    

    private void OnTriggerEnter(Collider other)
    {    if (other.gameObject.tag == "Player") //nesneyi tetikleyen objenin tagi Player ise aþaðýdaki adýmlarý izler
        {
            for (int i = 0; i < Drops.Length; i++)//bu dizi Drop listesinin uzunluðu kadar devam eder
            {
                Drops[i].SetActive(true); //Her bir drop nesnesinin setactive özelliðini true yapar.
            }
        }
    }
}
