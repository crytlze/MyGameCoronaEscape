using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public float skor;
    public Text skorUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            skor += 100;
            skorUI.text = "SKOR = " + skor.ToString();
            
        }
        
    }

}
