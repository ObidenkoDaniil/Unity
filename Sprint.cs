using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    public int health = 10;
    public int lvl = 1;
    public float speed = 1.2f;
    

    void Start()
    {
        health += lvl;
        print("Çהמנמגüו " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
