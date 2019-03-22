using UnityEngine;
using UnityEngine.UI;

public class TitleButtonScript : MonoBehaviour
{

    public void BeginButton()
    {
        GameObject panel = GameObject.Find("FadePanel");
        FadeIO fo = panel.GetComponent<FadeIO>();
        fo.doFadeOut(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.MainGame);
    }

    public void EndButton()
    {
        SceneChangeManager.SceneChange(SceneChangeManager.Scenes.End);
    }
}
