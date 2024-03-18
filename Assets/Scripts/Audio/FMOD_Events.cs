using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMOD_Events : MonoBehaviour
{
    public static FMOD_Events instance;

    //tutaj b�d� poszczeg�lne d�wi�ki
    [Header("Nazwa")]
    public EventReference nazwaEventu;


    private void Awake()
    {
        if (instance != null && instance != this) Destroy(this);
        else instance = this;
    }
}
