using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMovement : MonoBehaviour {

    public float toPosX;
    public float toPosY;
    public float time = 5;

	// Use this for initialization
	void Start () {
        toPosY = Random.Range(-3, 4);
        toPosX = Random.Range(0, 5);
        iTween.MoveTo(this.gameObject, iTween.Hash(
                                                    "x", toPosX,
                                                    "y", toPosY,
                                                    "time", time,
                                                    "easetype", "linear",
                                                    "looptype", "pingPong",
                                                    "onComplete", "FlipSprite"));

        if(this.gameObject.transform.position.x > toPosX)
        {
            FlipSprite();
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FlipSprite()
    {
        if(this.gameObject.GetComponent<SpriteRenderer>().flipX == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
            this.gameObject.GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);
            Destroy(this.gameObject, 0.5f);
        }
    }
}
