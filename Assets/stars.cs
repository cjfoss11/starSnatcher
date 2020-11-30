using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour
{
	public float delay = 2f;
	public GameObject star;

    // Start is called before the first frame update
    void Start()
    {
    	InvokeRepeating("Spawn", 0, delay);
        
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(star, new Vector2(1600, Random.Range(-800, 400)),Quaternion.identity);
    }
    

}
