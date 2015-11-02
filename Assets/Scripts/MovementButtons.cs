using UnityEngine;
using System.Collections;

public class MovementButtons : MonoBehaviour {

    private float all_button_widths     = 0f;
    private float all_button_heights    = 0f;
    private float all_button_pos_y      = 0f;
    
    private float left_button_pos_x     = 0f;
    private float down_button_pos_x     = 0f;
    private float up_button_pos_x       = 0f;
    private float right_button_pos_x    = 0f;

    public Texture left_button;
    public Texture down_button;
    public Texture up_button;
    public Texture right_button;
    public Texture player;

    Vector3 pos;                                // For movement
    float speed = 2.0f;                         // Speed of movement
    float move_distance_vert  = 0.780f;
    float move_distance_horiz = 0.805f;

    // Use this for initialization
    void Start()
    {
        all_button_widths   = Screen.width * 1 / 4f;
        all_button_heights  = Screen.height * 1 / 8f;
        all_button_pos_y    = Screen.height * 78 / 100;
        down_button_pos_x   = Screen.width * 1 / 4;
        up_button_pos_x     = Screen.width * 1 / 2;
        right_button_pos_x  = Screen.width * 3 / 4;

        pos = transform.position;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
    }

    void OnGUI()
    {
        GUI.backgroundColor = Color.clear; //transparent buttons

        //left button action
        if(GUI.Button(new Rect(left_button_pos_x, all_button_pos_y, all_button_widths, all_button_heights), left_button) && transform.position == pos)
        {
            if (pos.x < -2)
                ;
            else
                pos += new Vector3(-move_distance_horiz, 0);
        }

        //down button action
        if (GUI.Button(new Rect(down_button_pos_x, all_button_pos_y, all_button_widths, all_button_heights), down_button) && transform.position == pos)
        {
            if (pos.y < -1.3)
                ;
            else
                pos += new Vector3(0, -move_distance_vert);
        }

        //up button action
        if (GUI.Button(new Rect(up_button_pos_x, all_button_pos_y, all_button_widths, all_button_heights), up_button) && transform.position == pos)
        {
            if (pos.y > 3) //don't go too high
                ;
            else
                pos += new Vector3(0, move_distance_vert);
        }

        //right button action
        if (GUI.Button(new Rect(right_button_pos_x, all_button_pos_y, all_button_widths, all_button_heights), right_button) && transform.position == pos)
        {
            if (pos.x > 2)
                ;
            else
                pos += new Vector3(move_distance_horiz, 0);
        }
    }
}
