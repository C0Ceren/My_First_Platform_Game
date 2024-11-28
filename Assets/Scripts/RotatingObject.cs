using UnityEngine;

public class RotatingObject : MonoBehaviour

    //Scriptin eklendi�i nesneyi istenilen h�zda ve y�nde d�nd�r�r.
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
