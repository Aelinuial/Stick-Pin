using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    public float speed = 20f;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotater")
        {
            rb.velocity = Vector2.zero;
            if (Random.Range(0f, 1f) > 0.5f)
            {
                collision.GetComponent<Rotater>().speed *= -1;
            }
            collision.GetComponent<Rotater>().speed += 10;
            Score.scoreValue++;
            transform.SetParent(collision.transform);
        }else if (collision.tag == "Pin")
        {
            GameObject.FindObjectOfType<Manager>().GameOver();
        }
    }
}
