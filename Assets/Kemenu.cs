using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kemenu : MonoBehaviour
{
    // Start is called before the first frame update


    public void kemenu (string kemenu)
    {
        Application.LoadLevel (kemenu);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
