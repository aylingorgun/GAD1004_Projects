using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Text l_scoreText;
    public Text r_scoreText;

    public static int l_score;
    public static int r_score;

    // Start is called before the first frame update
    void Start()
    {
        r_score = 0;
        l_score = 0;
        
        l_scoreText.text = "0";
        r_scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        l_scoreText.text = " " + l_score;
        r_scoreText.text = " " + r_score;

        if(BallCollision.flag == true && (l_score < 3 || r_score < 3)){
            Invoke("Spawn", 2);
            BallCollision.flag = false;
        } else if(BallCollision.flag == true && (l_score >= 3 || r_score >= 3 )){
            Invoke("Spawn2", 2);
            BallCollision.flag = false;
            Ball.speed = 40;
        } 
        
    }

    void Spawn()
    {
        Instantiate(go);
    }

    void Spawn2()
    {
        Instantiate(go2);
    }
}
