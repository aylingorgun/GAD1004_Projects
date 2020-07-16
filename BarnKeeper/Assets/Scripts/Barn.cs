using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barn : MonoBehaviour
{
    public Text score_Text;
    int score;

    void Start()
    {
        score = 0;
        score_Text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score_Text.text = score.ToString();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
            this.gameObject.GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);
            score++;
        }
    }
}
