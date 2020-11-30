using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipmover : MonoBehaviour
{
    Vector2 MinPos;
    Vector2 MaxPos;

    void Start()
    {
        Vector2 Size = GetComponent<SpriteRenderer>().bounds.extents;
        MinPos = (Vector2)Camera.main.ViewportToWorldPoint(new Vector2(0, 0)) + Size;
        MaxPos = (Vector2)Camera.main.ViewportToWorldPoint(new Vector2(1, 1)) - Size - new Vector2(0, 210);
    }

    void Update()
    {
        Vector2 mousePos = (Input.mousePosition);
        Vector2 targetPos= new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x, Camera.main.ScreenToWorldPoint(mousePos).y);
        
        if (Input.GetMouseButton(0))
        {
            targetPos.x = MinPos.x;
            targetPos.y = Mathf.Clamp(targetPos.y, MinPos.y, MaxPos.y);
            transform.position = targetPos;
        }
        if (Input.GetKeyDown("space"))
        {
            NewLaser(targetPos);
        }
    }

    void NewLaser(Vector2 position)
    {   
        // Sprite laser;
        // Rect rect = new Rect(0, 0, 50, 20);
        // laser.Create(Texture2D.redTexture, rect, position);
    }
    void onClick()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}


