using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool ShadowRealmActive;

    public GameObject [] lightObjects;
    public GameObject [] darkObjects;


    private void Start()
    {
        lightObjects = GameObject.FindGameObjectsWithTag("LightObject");
        darkObjects = GameObject.FindGameObjectsWithTag("DarkObject");
    }

    private void Update()
    {

        if (ShadowRealmActive == true)
        {
            foreach (GameObject _lightPlats in lightObjects)
            {
                _lightPlats.SetActive(false);
            }

            foreach (GameObject _darkPlats in darkObjects)
            {
                _darkPlats.SetActive(true);
            }
        }

        else
        {
            foreach (GameObject _lightPlats in lightObjects)
            {
                _lightPlats.SetActive(true);
            }

            foreach (GameObject _darkPlats in darkObjects)
            {
                _darkPlats.SetActive(false);
            }
        }
        
        

        Debug.Log("ShadowRealmActive" + ShadowRealmActive);
        
    }

}
