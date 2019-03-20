using UnityEngine;

public class TitleButton : MonoBehaviour
{

    public void StartButton()
    {
        SceneChangeManager.SceneChange(SceneChangeManager.Scenes.MainGame);
    }

    public void EndButton()
    {
        SceneChangeManager.SceneChange(SceneChangeManager.Scenes.End);
    }
}
