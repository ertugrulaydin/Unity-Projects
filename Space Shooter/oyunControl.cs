using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunControl : MonoBehaviour
{
    public GameObject Astreoid;
    public Vector3 randomPos;
    public Text text;
    public Text gameOverText;
    public Text restartText;
    bool gameOverContrl = false;
    bool restartgameContrl = false;

    int score;
    int a=1;
    void Start()
    {

        score = 0;
        text.text = "score: " + score;
        StartCoroutine(olustur());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && restartgameContrl)
        {
            SceneManager.LoadScene("level1");
        }
    }

    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);
        while (a == 1)
        {

            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Astreoid, vec, Quaternion.identity);
                yield return new WaitForSeconds(1.5f);
                if (gameOverContrl == true)
                {
                    restartText.text = "Press 'R' for Restart";
                    restartgameContrl = true;
                    a = 0;
                    break;
                }
            }

            yield return new WaitForSeconds(2);


        }
        
        
    }

    public void Score(int score_)
    {
        score += score_;
        text.text = "score: " + score;

    }
    public void OyunBitti()
    {
        gameOverText.text = "Game Over";
        gameOverContrl = true;
    }
}
