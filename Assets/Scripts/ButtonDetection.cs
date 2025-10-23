using System.Threading;
using UnityEngine;


public class ButtonDetection : MonoBehaviour
{
    bool Pressed;
    private void OnTriggerEnter(Collider other)
    {
        Pressed = true;
    }

    private void Update()
    {
        if (Pressed)
        {
            var newPos = transform.position;
            newPos.y += 1*Time.deltaTime;
            transform.position = newPos;
        }
    }
}
