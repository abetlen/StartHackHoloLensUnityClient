/*===============================================================================
Copyright (c) 2016 PTC Inc. All Rights Reserved.

Confidential and Proprietary - Protected under copyright and other laws.
Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelShowHide : MonoBehaviour 
{
    public Text _text;
    public UnityEngine.UI.Image _image;

	public void Hide()
    {
        _image.canvasRenderer.SetAlpha(0);
    }

    public void Show(string title, string id, Sprite image)
    {
        _text.text = title;
        _image.sprite = image;
        _image.canvasRenderer.SetAlpha(0);
        _image.preserveAspect = true;
    }

    public void ResetShowTrigger()
    {
        _image.canvasRenderer.SetAlpha(0);
    }
}
