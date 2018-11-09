using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFlash : MonoBehaviour {

    float alphaSpeed = 4.0f;
    CanvasGroup Btns;
    bool flash = true;

	// Use this for initialization
	void Start () {
        Btns = this.transform.GetComponent<CanvasGroup>();
	}
	
	// Update is called once per frame
	void Update () {
        if (flash)
        {
            Btns.alpha = Mathf.Lerp(Btns.alpha, 1.0f, alphaSpeed * Time.deltaTime);
            if (1.0-Btns.alpha<=0.01)
            {
                flash = false;
            }
        }
        else
        {
            Btns.alpha = Mathf.Lerp(Btns.alpha, 1.0f, alphaSpeed * Time.deltaTime);
            if (1.0 - Btns.alpha <= 0.01)
            {
                flash = true;
            }
        }
	}
}
