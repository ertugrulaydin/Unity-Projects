using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YilanKontrol : MonoBehaviour
{
    public GameObject yemPrefab;
    Vector3 vec;
    public float hiz;
    public float donusHizi;
    public List<GameObject> kuyrukObjects = new List<GameObject>();
    public float z_offset = 0.5f;

    public GameObject kuyrukPrefab;
    public int score = 0;
    public Text ScoreText;
    public Text GameOverText;
    public Text GameOverScoreText;
    bool scoregameover;
    public GameObject bonusYemPrefab;
    int yemCount=0;
    float timeLeft;
    float timeLeft2;
    public Text SureText;
    bool boolSure = false;
    bool yilanDur = false;


    void Start()
    {
        
        kuyrukObjects.Add(gameObject);
    }

    void FixedUpdate()
    {
        //scorecontrol();
        transform.Translate(Vector3.forward * hiz * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * donusHizi * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up *-1 * donusHizi * Time.deltaTime);
        }
        Surecontrol();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "yem")
        {
            Destroy(other.gameObject);
            Vector3 vec = new Vector3(Random.Range(19.5f, -21.0f), 0.566f, Random.Range(14.0f, -15.0f));
            Instantiate(yemPrefab, vec, Quaternion.identity);
            yemCount += 1;
            KuyrukEkle();

        }
        if(other.tag == "bonusYem")
        {

            Destroy(other.gameObject);
            score += 5;
            boolSure = false;
            SureText.text = " ";
            yemCount = 0;
        }
        if (yemCount % 5 == 0 && yemCount > 0)
        {
            timeLeft = 10.0f;

            Vector3 vec = new Vector3(Random.Range(19.5f, -21.0f), 0.566f, Random.Range(14.0f, -15.0f));
            Instantiate(bonusYemPrefab, vec, Quaternion.identity);
            boolSure = true;
            


        }
        if (other.tag == "border")
        {
            GameOverText.text = "GAME OVER";
            GameOverScoreText.text = "Score: " + score;
            scoregameover = true;
            timeLeft2 = 1.0f;

        }
    }

    public void KuyrukEkle()
    {
        score++;
        Vector3 yeniKuyrukPoz = kuyrukObjects[kuyrukObjects.Count - 1].transform.position;
        yeniKuyrukPoz.z -= z_offset;
        kuyrukObjects.Add(GameObject.Instantiate(kuyrukPrefab, yeniKuyrukPoz, Quaternion.identity));
    }



    void Surecontrol()
    {

        if (boolSure)
        {
            SureText.text = "" + (int)timeLeft;
            timeLeft -= Time.deltaTime;
            timeLeft2 -= Time.deltaTime;

            if (timeLeft < 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("bonusYem").gameObject);
                boolSure = false;
                SureText.text = " ";
                
            }
        }
        if(scoregameover)
        {
            ScoreText.text = " ";
            timeLeft2 -= Time.deltaTime;
            if (timeLeft2 < 0)
            {
                SceneManager.LoadScene("SceneOpen");
            }
        }
        else
        {

            ScoreText.text = "Score: " + score;
        }
        
    }

}
