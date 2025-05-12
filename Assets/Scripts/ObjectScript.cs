using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public GameObject garbageTruck;
    public GameObject SchoolBus;
    public GameObject Medic;


    [HideInInspector]
    public Vector2 gTruckPos;
    [HideInInspector]
    public Vector2 SBusPos;
    [HideInInspector]
    public Vector2 MedicPos;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    [HideInInspector]
    public bool rightPlace = false;
    public GameObject lastDragged = null;



    void Start()
    {
        gTruckPos = garbageTruck.GetComponent<RectTransform>().localPosition;
        SBusPos = SchoolBus.GetComponent<RectTransform>().localPosition;
        MedicPos = Medic.GetComponent<RectTransform>().localPosition;
    }


  
}