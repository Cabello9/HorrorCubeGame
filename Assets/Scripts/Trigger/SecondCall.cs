﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCall : MonoBehaviour {

    public GameObject entrancePhone;
    public GameObject activateSound;

    private void OnTriggerEnter(Collider other)
    {
        entrancePhone.GetComponent<Phone>().ring();
        entrancePhone.GetComponent<Phone>().triggerStopCall = true;
        FindObjectOfType<ImportantThingsDetection>().lengthDetection = 0.75f;
        activateSound.GetComponent<AudioSource>().Play();
        Destroy(this.gameObject);
    }
}
