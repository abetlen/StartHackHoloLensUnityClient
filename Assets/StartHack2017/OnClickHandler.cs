using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class OnClickHandler : MonoBehaviour {
    private GestureRecognizer recognizer;

    // Use this for initialization
    void Start () {
        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap);
        recognizer.TappedEvent += TapEventHandler;
        recognizer.StartCapturingGestures();

        GetComponent<CanvasRenderer>().SetAlpha(0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) {
            GetComponent<CanvasRenderer>().SetAlpha(1);
            Debug.Log("clicked");
        }

        Debug.Log("over");
    }

    private void OnDestroy()
    {
        recognizer.TappedEvent -= TapEventHandler;
    }

    private void TapEventHandler(InteractionSourceKind source, int tapCount, Ray headRay)
    {
        RaycastHit hit;
        var coll = GetComponent<Collider>();

        if (coll.Raycast(headRay, out hit, 100.0F)) {
            GetComponent<CanvasRenderer>().SetAlpha(1);
            Debug.Log("tapped");
        }
    }
}
