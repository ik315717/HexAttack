using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    /********************************************************************************
    ** For now this function just moves the character every second. There should be
    ** an array that holds all the clocks images to count down over a certain amount
    ** of time and loops through the array accordingly until the enemy is to move.
    ** Then as time goes on (after 20 seconds or whatever) the time that it takes the
    ** enemies to move increases every 20 seconds or whatever you choose. This class
    ** should keep track of scoring IF it's dependent on time. If it's movements then
    ** use the MovementButtons class to keep score.
    *********************************************************************************/

    Vector3 pos;                                // For movement
    float speed = 2.0f;                         // Speed of movement
    float move_distance_vert = 0.780f;
    float move_distance_horiz = 0.805f;
    int random_direction = 0;
    float time_to_move = 0f;

    // Use this for initialization
    void Start()
    {
        pos = transform.position;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
    }

    void Update()
    {
        time_to_move += Time.deltaTime;
        if (time_to_move >= 1.0f)
        {
            random_direction = Random.Range(0, 5);
            RandomMovement(random_direction);
            time_to_move = 0f;
        }
    }


    void MoveLeft()
    {
        if (pos.x < -2) // Don't go too far left
        {
            random_direction = Random.Range(0, 5);
            while(random_direction == 1) //if 1, pick new direction (so it's not left again)
                random_direction = Random.Range(0, 5);
            RandomMovement(random_direction);
        }
        else
            pos += new Vector3(-move_distance_horiz, 0);
    }

    void MoveDown()
    { 
        if (pos.y < -1.3) //Don't go too 
        {
            random_direction = Random.Range(0, 5);
            while (random_direction == 2) //if 2, pick new direction (so it's not down again)
                random_direction = Random.Range(0, 5);
            RandomMovement(random_direction);
        }
            else
                pos += new Vector3(0, -move_distance_vert);
    }

    void MoveUp()
    {
        if (pos.y > 3) //Don't go too high
        {
            random_direction = Random.Range(0, 5);
            while (random_direction == 3) //if 3, pick new direction (so it's not up again)
                random_direction = Random.Range(0, 5);
            RandomMovement(random_direction);
        }
                
            else
                pos += new Vector3(0, move_distance_vert);        
    }

    void MoveRight()
    {
        ArrayList movement = new ArrayList();
        
        if (pos.x > 2) //Don't go too far right
        {
            random_direction = Random.Range(0, 5);
            while (random_direction == 4) //if 4, pick new direction (so it's not right again)
                random_direction = Random.Range(0, 5);
            RandomMovement(random_direction);
        }
        else
            pos += new Vector3(move_distance_horiz, 0);
    }

    void RandomMovement(int random_number) //If enemy cannot move one way, go a different direction
    {
        switch(random_number)
        {
            case 1:
                MoveLeft();
                break;
            case 2:
                MoveDown();
                break;
            case 3:
                MoveUp();
                break;
            case 4:
                MoveRight();
                break;
            default:
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //this should call a GAME OVER screen, not implented yet, will be very soon (a quick addition)
    }

}
