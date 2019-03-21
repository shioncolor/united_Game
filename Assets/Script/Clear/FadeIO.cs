using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIO : MonoBehaviour {

    public float speed = 0.01f;
    float alfa = 0;
    float r, g, b;

	// Use this for initialization
	void Start () {
        this.r = GetComponent<Image>().color.r;
        this.g = GetComponent<Image>().color.g;
        this.b = GetComponent<Image>().color.b;
	}

    // Update is called once per frame
    void Update() {
        if (alfa < 0.4)
        {
            GetComponent<Image>().color = new Color(r, g, b, alfa);
            alfa += speed;
        }
	}
}
