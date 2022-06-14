
Hareket



using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hareket
{

    public float hareketHizi;

    void Start()
    {

    }

    void Update()
    {
        hareketEt();
    }

    void hareketEt()
    {
        transform.Translate(Vector3.left * hareketHizi * Time.deltaTime);
    }
}










