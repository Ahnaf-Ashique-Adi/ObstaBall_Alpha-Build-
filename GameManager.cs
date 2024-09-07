using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Gamemanager : MonoBehaviour
{
    public GameObject obstacle; //spwan type
    public Transform spawnPoint; //spwan position
    int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject Playbutton;
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
       // GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacles() 
    {
        while (true)
        {
            float waitTime = Random.Range(.8f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle,spawnPoint.position, Quaternion.identity);
        }

    }
    void ScoreUp() 
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void GameStart() 
    {
        Player.SetActive(true);
        Playbutton.SetActive(false);
        StartCoroutine(SpawnObstacles());
        InvokeRepeating("ScoreUp", 2f, 1f);
                                                     
    } 
}
