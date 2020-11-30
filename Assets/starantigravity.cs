using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starantigravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Update", 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
 		GetComponent<Rigidbody2D>().AddForce(Vector2.left * 29.4f);

    }
}
