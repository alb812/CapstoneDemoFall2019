using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBehaviorMG : MonoBehaviour
{
    // Start is called before the first frame update

    private EnemySpawnerMG shadows;
    
    //speed object scales
    public float speed = 3.0f;
    private Vector3 temp;
    public int numOfSpawns = 5;

    public bool isGrowing;


    public PlayerMiniGameMovement thePlayerScript;
    
    
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
