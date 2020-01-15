using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 25f; //base speed of the wander object
    Vector3 wayPoint; //a coordinate randomly chosen

    // Update is called once per frame
    void Start()
    {
        ChooseHeading();
    }
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;//move the player towards the wayPoint
        if((transform.position - wayPoint).magnitude < 3)//if the player is within 3 units of the wayPoint choose a new one
        {
            ChooseHeading();
        }
    }

    void ChooseHeading()//picks the next wayPoint
    {
        wayPoint = Random.insideUnitSphere * 47;//multiplied by a constant to make sure the wayPoint is far awy from the player
        wayPoint.y = 1;//y component is not nescessary
        transform.LookAt(wayPoint);//look at the wayPoint
    }
}
