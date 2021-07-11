using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour, IInActiveAwake
{
    public virtual void InActiveAwake()
    {
        Debug.Log("[TestScript] InActiveAwake!");

        /* you could call Awake in there */
        //Awake();
    }

    private void Awake()
    {
        Debug.Log("[TestScript] Awake!");
    }

    /* to be able to enable-disable script */
    private void Update()
    {
        
    }
}
