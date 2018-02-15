using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColourChange : MonoBehaviour {

    public Text CycleColorText;
    private int iter = 1;

    // Use this for initialization
    void Start () {
        StartCoroutine(ColorChangeDelay());
    }
	
	// Update is called once per frame
	void Update () {

    }



    IEnumerator ColorChangeDelay()
    {
        //Debug.Log("function works");

        while (iter < 5)
        {

            if (iter == 1)
            {
                CycleColorText.color = Color.red;
                //Debug.Log("red");            
                yield return new WaitForSeconds(.05f);
                iter++;
            }

            if (iter == 2)
            {
                CycleColorText.color = Color.blue;
                //Debug.Log("green");
                yield return new WaitForSeconds(.05f);
                iter++;
            }

            if (iter == 3)
            {
                CycleColorText.color = Color.green;
                //Debug.Log("blue");            
                yield return new WaitForSeconds(.05f);
                iter++;
            }
            if (iter == 4)
            {
                CycleColorText.color = Color.yellow;
                //Debug.Log("green");
                yield return new WaitForSeconds(.05f);
                iter = 1;
            }
        }
    }
}
