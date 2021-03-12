using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public static int check = 0;
    SpriteRenderer sprite;

    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        Time.timeScale = 1.0f;
        
    }
    void FixedUpdate()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * (speed + PinSpeed.pinSpeed) * Time.fixedDeltaTime); 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        }
        else if(col.tag == "Pin")
        {
            sprite.color = new Color(1, 0, 0, 1);

            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("End Game");
            SaveBinary.loaded = 0;

            check = 1;
        }
    }
}