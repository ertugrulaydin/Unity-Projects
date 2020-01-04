using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_ast : MonoBehaviour
{
    public GameObject patlama;
    public GameObject playerPatlama;
    GameObject OyunKontrol;

    oyunControl kontrol;

    private void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = OyunKontrol.GetComponent<oyunControl>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "mermi" ) {
            Destroy(col.gameObject);//bize çarpanı(col=mermi) yok eder
            Destroy(gameObject);//kendimizi(astreoidi yok eder)
            Instantiate(patlama, transform.position, transform.rotation);
            kontrol.Score(10);
        }



        if (col.tag == "Player")
        {
            Destroy(col.gameObject);//bize çarpanı(col=mermi) yok eder
            Destroy(gameObject);//kendimizi(astreoidi yok eder)
            Instantiate(patlama, transform.position, transform.rotation);
            Instantiate(playerPatlama, col.transform.position, col.transform.rotation);
            kontrol.OyunBitti();
        }
    }
}
