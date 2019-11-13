using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerDisplay : MonoBehaviour
{
    Image powerBar;
    public static float power;
    private float startPower;
    float maxPower = 100f;
    // Start is called before the first frame update
    void Start()
    {
        powerBar = GetComponent<Image>();
        //power = maxPower;
        power = 0;
    }

    // Update is called once per frame
    void Update()
    {
        powerBar.fillAmount = power / maxPower;  
    }
}
