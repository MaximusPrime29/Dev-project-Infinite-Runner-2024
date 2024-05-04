using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();


    }

    // Update is called once per frame
    void Update()
    {

        //If the player is died and obstacles should not move then the objects dont move
        if(gm.playerLive==false || PauseControl.gameIsPaused == true) 
        {

            
                
        }
        else
        {
            transform.position += new Vector3(0, 0, -2) * Time.deltaTime;

        }

        






        //used to make the level anfd enemies move
        //transform.position += new Vector3(0, 0, -2) * Time.deltaTime;







    }
   
}
