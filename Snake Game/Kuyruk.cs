using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kuyruk : MonoBehaviour
{
    public float hiz;
    public Vector3 hedefKuyruk;
    public GameObject hedefKuyrukObj;
    public YilanKontrol mainSnake;
    public int index;
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("yilanBas").GetComponent<YilanKontrol>();
        hiz = mainSnake.hiz + 2.5f;
        hedefKuyrukObj = mainSnake.kuyrukObjects[mainSnake.kuyrukObjects.Count - 2];
        index = mainSnake.kuyrukObjects.IndexOf(gameObject);

    }

    void Update()
    {
        hedefKuyruk = hedefKuyrukObj.transform.position;
        transform.LookAt(hedefKuyruk);
        transform.position = Vector3.Lerp(transform.position, hedefKuyruk, Time.deltaTime * hiz);
    }
}
