using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool ShadowRealmActive;

    public GameObject [] lightPlats;
    public GameObject [] darkPlats;


    private void Start()
    {
        lightPlats = GameObject.FindGameObjectsWithTag("LightPlatform");
        darkPlats = GameObject.FindGameObjectsWithTag("DarkPlatform");
    }

    private void Update()
    {

        if (ShadowRealmActive == true)
        {
            foreach (GameObject _lightPlats in lightPlats)
            {
                _lightPlats.SetActive(false);
            }

            foreach (GameObject _darkPlats in darkPlats)
            {
                _darkPlats.SetActive(true);
            }
        }

        else
        {
            foreach (GameObject _lightPlats in lightPlats)
            {
                _lightPlats.SetActive(true);
            }

            foreach (GameObject _darkPlats in darkPlats)
            {
                _darkPlats.SetActive(false);
            }
        }
        
        

        Debug.Log("ShadowRealmActive" + ShadowRealmActive);
        
    }

}
