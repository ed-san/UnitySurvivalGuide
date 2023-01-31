using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{

    public int score;
    public float speed = 3.0f;
    public int health = 100;
    public int ammoCount = 10;
    public bool allKeysCollected = false;

    public GameObject player;
    public Animation anim;
    public Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myTransform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
