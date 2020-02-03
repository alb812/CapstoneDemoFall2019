using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCounterScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int EnemyKillCount;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void EndMiniGame()
    {
        if (EnemyKillCount == 0)
        {
            SceneManager.LoadScene("PrototypeScene1");
        }
    }
}
