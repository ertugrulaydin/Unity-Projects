using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YemRotate : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz = 5;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere * hiz;
    }

 
}
