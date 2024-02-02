using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOnOff : MonoBehaviour
{

    public GameObject rightLight;
    public GameObject leftLight;
    // Start is called before the first frame update
    void Start()
    {
        rightLight.SetActive(false);
        leftLight.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        rightLight.SetActive(!rightLight.activeSelf);
        leftLight.SetActive(!leftLight.activeSelf);
    }
    private void OnTriggerExit(Collider other)
    {
        rightLight.SetActive(!rightLight.activeSelf);
        leftLight.SetActive(!leftLight.activeSelf);
    }
}
