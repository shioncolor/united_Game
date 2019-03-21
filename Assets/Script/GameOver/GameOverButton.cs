using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverButton : MonoBehaviour {
    
	public void BeginButton () {
        SceneChangeManager.SceneChange(SceneChangeManager.Scenes.MainGame);
    }
	
	public void HomeButton () {
        SceneChangeManager.SceneChange(SceneChangeManager.Scenes.Title);
    }
}
