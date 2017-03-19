using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickHandler : MonoBehaviour {
    // Use this for initialization
    void Start () {
        var comp = GetComponent<CanvasRenderer>();
        comp.SetAlpha(0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var comp = GetComponent<CanvasRenderer>();
            comp.SetAlpha(1);
            Debug.Log("clicked");
        }

        Debug.Log("over");
    }
}
