using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameKontrol : MonoBehaviour
{
    public GameObject yemPrefab;
    Vector3 vec;
    /*public Text ScoreText;
    public Text GameOverText;
    public Text GameOverScoreText;
    bool scoregameover;*/
    public YilanKontrol mainSnake;
    /*float timeLeft;*/




    void Start()
    {
        Vector3 vec = new Vector3(Random.Range(19.5f, -21.0f), 0.566f, Random.Range(14.0f, -15.0f));
        Instantiate(yemPrefab,vec,Quaternion.identity);
        mainSnake = GameObject.FindGameObjectWithTag("yilanBas").GetComponent<YilanKontrol>();
    }
    /*void FixedUpdate()
    {
        scorecontrol();

        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "yilanBas")
        {
            //mainSnake = GameObject.FindGameObjectWithTag("yilanBas").GetComponent<YilanKontrol>();
            GameOverText.text = "GAME OVER";
            GameOverScoreText.text = "Score: " + mainSnake.score;
            scoregameover = true;
            
            mainSnake.hiz = 0;
            timeLeft = 3.0f;

        }
        

    }
    void scorecontrol()
    {
        if (scoregameover)
        {
            ScoreText.text = " ";
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                SceneManager.LoadScene("SceneOpen");
            }
        }
        else
        {
            
            ScoreText.text = "Score: " + mainSnake.score ;
        }
    }*/

}
