using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrive : MonoBehaviour
{
    public GameObject player; //reference to player
    public float speed; //multiplier for AI travel speed
    Vector3 playerVector; //reference to the player position

    // Update is called once per frame
    void Update()
    {
        speed = 5f;
        playerVector = player.transform.position; //get the player position
        playerVector.y = 1;
        transform.position += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime; //move towards the player
        transform.LookAt(playerVector); //look at the player

        if ((player.transform.position - transform.position).magnitude < 10) //if arrive is within 10 units, half speed
        {
            speed = speed / 2;
            transform.position += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;
            transform.LookAt(playerVector);
        }
        if((player.transform.position - transform.position).magnitude < 5) //if arrive is within 5 units, 1 tenth speed
        {
            speed = speed / 10;
            transform.position += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;
            transform.LookAt(playerVector);
            Debug.Log("made it!");
        }
    }
}
