using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCorona : MonoBehaviour
{
    public GameObject virus;
    public float WaktuMin, WaktuMax;
    public float PosisiMin, PosisiMax;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculCorona());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculCorona()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(PosisiMin, PosisiMax), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(WaktuMin,WaktuMax));
        StartCoroutine(MunculCorona());
    }
}
