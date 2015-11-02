using UnityEngine;
using System.Collections;

/************************
This script should be renamed. It doesn't control player movement anymore.
*************************/

public class PlayerMovement : MonoBehaviour {

    Vector3 pos;                                // For movement
    float speed = 2.0f;                         // Speed of movement
    private bool paused = false;
    public Texture Pause_Button;

    void Start()
    {
        pos = transform.position;          // Take the initial position
    }

    /* THESE ARE FROM OLD CODE, KEPT IN CASE OF ISSUES
    //void FixedUpdate()
    //{
    //    if (Input.GetKey(KeyCode.A) && transform.position == pos)
    //    {        // Left
    //        pos += Vector3.left;
    //    }
    //    if (Input.GetKey(KeyCode.D) && transform.position == pos)
    //    {        // Right
    //        pos += Vector3.right;
    //    }
    //    if (Input.GetKey(KeyCode.W) && transform.position == pos)
    //    {        // Up
    //        pos += Vector3.up;
    //    }
    //    if (Input.GetKey(KeyCode.S) && transform.position == pos)
    //    {        // Down
    //        pos += Vector3.down;
    //    }
    //    transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
    //}
    */

    void OnGUI()
    {
        GUI.backgroundColor = Color.clear;
        GUI.skin.button.fontSize = 30;
        if (GUI.Button(new Rect(Screen.width - 150, 0, 150, 75), Pause_Button))
        {
            paused = togglePause();
        }

        GUI.backgroundColor = Color.black;
        if (paused)
        {
            GUILayout.BeginArea(new Rect(Screen.width / 2f, Screen.height / 2f, 300, 500));
            GUI.skin.label.normal.textColor = Color.black;
            GUILayout.Label("");
            if (GUILayout.Button("Continue", GUILayout.Height(100)))
                paused = togglePause();
            if (GUILayout.Button("Main Menu", GUILayout.Height(100)))
                Application.LoadLevel("MainMenuScene"); //No Main Menu yet, but just change this to whatever the MM scene is called to load it
            GUILayout.EndArea();
        }
    }


    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }

}
