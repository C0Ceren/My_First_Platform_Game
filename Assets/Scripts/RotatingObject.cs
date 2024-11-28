using UnityEngine;

public class RotatingObject : MonoBehaviour

    //Scriptin eklendiði nesneyi istenilen hýzda ve yönde döndürür.
{
    [SerializeField] float YAngle;
    [SerializeField] float XAngle;
    [SerializeField] float ZAngle;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(XAngle, YAngle, ZAngle);
    }
}
