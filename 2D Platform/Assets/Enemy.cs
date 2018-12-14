using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health;
    public float speed;

    private bool isAlive = true;

    private Animator anim;

    void start(){
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
    }

	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
		}

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Movement Movement = collision.gameObject.GetComponent<Movement>();
        if (Movement == null) { return; }
        Kill();
    }
    private void Kill()
    {
        Destroy(gameObject);
        if (!isAlive) { return; }
        isAlive = false;
        gameObject.layer = 13;
    }*/


    public void TakeDamage(int damage){
        health -= damage;
        Debug.Log("damage TAKEN !");
    }
}
