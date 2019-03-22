using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIO : MonoBehaviour {

    public delegate void SceneChange(SceneChangeManager.Scenes SceneId);

    [SerializeField]
    public float speed;

    Image image;
    float r, g, b, a;
    SceneChange change;
    SceneChangeManager.Scenes SceneId;
    bool running;

    // Use this for initialization
    void Start() {
        image = GetComponent<Image>();
        
        r = 0;
        g = 0;
        b = 0;
        image.enabled = false;
        running = false;
    }

    // Update is called once per frame
    void Update() {
        if (0 <= a && a <= 1 && running)
        {
            image.enabled = true;
            image.color = new Color(r, g, b, a);
            a += speed;
        }
        else if (running)
        {
            if (a < 0) image.color = new Color(r, g, b, 0);
            else image.color = new Color(r, g, b, 1.0f);
            running = false;
            Invoke("changeScene", 1.0f);
        }
    }

    public void doFadeOut(SceneChange _change, SceneChangeManager.Scenes _id)
    {
        this.running = true;
        this.change = _change;
        this.SceneId = _id;
        this.a = 0;
        this.speed = 0.06f;
    }

    public void doFadeIn(SceneChange _change, SceneChangeManager.Scenes _id)
    {
        this.running = true;
        this.change = _change;
        this.SceneId = _id;
        this.a = 1;
        this.speed = -0.06f;
    }

    void changeScene()
    {
        change(SceneId);
    }
}
