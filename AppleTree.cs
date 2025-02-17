using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class AppleTree : MonoBehaviour
{
    [Header("inscribed")]

    public GameObject applePrefab;
    public GameObject poisonApplePrefab;

    //apple tree move speed
    public float speed = 1f;

    // distance for turn around
    public float leftAndRightEdge = 10f;

    //chance that tree changes direction
    public float changeDirChance = 0.1f;

    //seconds between apple;
    public float appleDropDelay = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke ("DropApple", 2f);
    }

    void DropApple(){
        //Poison drops and apple drops
        float randomValue = UnityEngine.Random.Range(0f, 100f);
        int ranced =  (int)randomValue;
        ranced = ranced % 5;
        if(ranced == 0){
            GameObject apple = Instantiate<GameObject>(poisonApplePrefab);
            apple.transform.position = transform.position;
            Invoke ("DropApple", appleDropDelay);
        }else{
            //origin
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position;
            Invoke ("DropApple", appleDropDelay);
            //origin end
        }
    }

    // Update is called once per frame
    void Update()
    {
        //move
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //direct
        if(pos.x < -leftAndRightEdge){
            speed = Mathf.Abs(speed);
        }else if(pos.x > leftAndRightEdge){
            speed = -Mathf.Abs(speed);
        //}else if (Random.value < changeDirChance){
        //    speed*=-1;  //random chance change dir
        }
    }

    void FixedUpdate(){
        //time based rand direction changes
        if(Random.value < changeDirChance){
            speed *= -1;
        }
    }


}
