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
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //makes the shadows increase in size
         temp = transform.localScale;
         //increase size by temp 
         temp.x += Time.deltaTime;
         temp.y += Time.deltaTime;                                             
         //                                             
          transform.localScale = temp;                                                                                                 
                                                            
        
        
    }
}
