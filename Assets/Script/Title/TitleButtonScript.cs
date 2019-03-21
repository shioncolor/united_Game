using UnityEngine;
using UnityEngine.UI;

public class TitleButtonScript : MonoBehaviour
{

    public void BeginButton()
    {
        GameObject panel = GameObject.Find("FadeOutPanel");
        FadeOut fo = panel.GetComponent<FadeOut>();
        fo.begin(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.MainGame);
    }

    public void EndButton()
    {
        SceneChangeManager.SceneChange(SceneChangeManager.Scenes.End);
    }
}
