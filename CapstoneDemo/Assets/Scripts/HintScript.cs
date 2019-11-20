using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject interactHint;
    
    public void Enable()
    {
        interactHint.SetActive(true);
    }

    // Update is called once per frame
   public void Disable()
    {
        interactHint.SetActive(false);
    }
}
