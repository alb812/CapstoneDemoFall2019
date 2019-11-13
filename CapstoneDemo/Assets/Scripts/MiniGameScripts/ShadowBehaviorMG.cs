using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBehaviorMG : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject shadows;
    
    //speed object scales
    public float speed = 3.0f;

    private Vector3 temp;   
    
    //Range of shadows to spawn
    //public int NumMin;
   // public int NumMax;
    
    //how many prefabs were created
    //public int num;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;
        //increase size by temp 
        temp.x += Time.deltaTime;
        temp.y += Time.deltaTime;
        //
        transform.localScale = temp;
    }
}
