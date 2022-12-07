using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventAnim : MonoBehaviour
{
    public AudioSource As;

    void TocaMsg()
    {
        As.Play();
        print("Evento!!!");


    }
}
