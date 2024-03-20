using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEventPublisher : MonoBehaviour
{
    public ExEventChannel[] eventChannel;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            eventChannel[0].RaiseEvent();
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            eventChannel[1].RaiseEvent();
        }
    }
}
