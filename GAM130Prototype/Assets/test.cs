using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool ifPressed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("e") && ifPressed == false)
        {
            StartCoroutine(Trigger());
            ifPressed = true;
        }
    }

    IEnumerator Trigger()
    {
        Debug.Log("started");
        yield return new WaitForSeconds(1);
        Debug.Log("end");
        ifPressed = false;
    }
}
