using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRace : MonoBehaviour
{
    public class Dragster
    {
        private float topSpeed;
        private float accel;
        public float speed;

        public Dragster(float myTopSpeed, float myAccel)
        {
            topSpeed = myTopSpeed;
            accel = myAccel;
            speed = 0f;
        }
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        Dragster[] contestants = new Dragster[2];


        for (int i = 0; i < contestants.Length; i++)
        {
            contestants[i] = new Dragster(Random.Range(450f, 520f), Random.Range(11f, 15f));
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
