using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    public Texture background_img;

	// Use this for initialization
	void Start () {
	
	}

    void OnGUI()
    {
        // Create background, make it fit any screen size

        GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), background_img);

        GUI.skin.button.fontSize = 50;
        if (GUI.Button(new Rect(Screen.width/4.0f, Screen.height / 2.0f, Screen.width / 2.0f, Screen.height / 8.0f), "Play!"))
            Application.LoadLevel("GameScreen");
    }
}
