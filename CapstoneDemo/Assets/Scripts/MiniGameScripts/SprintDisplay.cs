using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SprintDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    Image sprintBar;
    public static float sprint;
    float maxSprint = 100f;
    //public Text healthText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        sprintBar = GetComponent<Image>();
        sprint = maxSprint;
    }

    // Update is called once per frame
    void Update()
    {
        sprintBar.fillAmount = sprint / maxSprint;
    }
}
