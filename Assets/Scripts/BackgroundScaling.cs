using UnityEngine;
using System.Collections;

public class BackgroundScaling : MonoBehaviour {

    //public Texture background_img;
    public GameObject background;
    private GameObject other_bg;

    void Start()
    {
        // Keep screen in portrait mode for mobile
        Screen.orientation = ScreenOrientation.Portrait;

        //background.transform.localScale = new Vector3(1, 1, 1);
        other_bg = Instantiate(background, new Vector3(0, 0, 10), transform.rotation) as GameObject;
        other_bg.transform.localScale = new Vector3(Screen.width, Screen.width, 1);
        
    }

    void Update()
    {
        
    }
    //void OnGUI()
    //{
    //    // Create background, make it fit any screen size
    //    GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height * 8 / 10), background_img);
    //}
}
