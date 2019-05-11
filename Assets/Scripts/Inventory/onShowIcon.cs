using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onShowIcon : MonoBehaviour
{
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (!image.enabled && image.sprite != null)
        {
            image.enabled = true;
        }
        else if(image.enabled && image.sprite==null) image.enabled = false;
    }
}
