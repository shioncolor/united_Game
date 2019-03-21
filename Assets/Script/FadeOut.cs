using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

    public delegate void SceneChange(SceneChangeManager.Scenes SceneId);

    [SerializeField]
    public float speed = 0.06f;

    Image image;
    float r, g, b, a;
    SceneChange change;
    SceneChangeManager.Scenes id;
    bool running;

    // Use this for initialization
    void Start() {
        image = GetComponent<Image>();

        Debug.Log("Started.");
        r = 0;
        g = 0;
        b = 0;
        a = 0;
        image.enabled = false;
        running = false;
    }

    // Update is called once per frame
    void Update() {
        if (a < 1 && running)
        {
            image.enabled = true;
            image.color = new Color(r, g, b, a);
            a += speed;
        }
        else if (running)
        {
            image.color = new Color(r, g, b, 1.0f);
            Debug.Log("Ended");
            running = false;
            Invoke("changeScene", 1.0f);
        }
    }

    public void begin(SceneChange _change, SceneChangeManager.Scenes _id)
    {
        this.running = true;
        this.change = _change;
        this.id = _id;
    }

    void changeScene()
    {
        change(id);
    }
}
