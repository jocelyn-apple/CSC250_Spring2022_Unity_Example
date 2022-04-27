using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerScript : MonoBehaviour
{
    private Room thisRoom;

    // Start is called before the first frame update
    void Start()
    {
        this.thisRoom = new Room();
        CORE.addRoom(this.thisRoom);
        CORE.addRoomTrigger(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            this.thisRoom.setPlayer(CORE.getPlayer()); //lets new room know about the player
            print("Player now in room: " + this);
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
            this.thisRoom.setEnemy(CORE.getEnemy());
            print("Enemy Entered Room: " + this.gameObject.ToString());
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            CORE.destroyRoom(this.gameObject);
        }
        else if (other.gameObject.tag.Equals("enemy"))
        {
            CORE.destroyRoom(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
