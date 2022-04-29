using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    private Player thePlayer;
    private Enemy theEnemy;
    private GameObject currentRoomTrigger;

    public Room()
    {
        this.thePlayer = null;
        Room enemysCurrentRoom = enemysCurrentRoom.getRoom();
        CORE.destroyRoom(enemysCurrentRoom.currentRoomTrigger);
        this.theEnemy = null;
    }

    public Room(GameObject currentRoomTrigger)
    {
        ...
    }

    public void setPlayer(Player p)
    {
        this.thePlayer = p;
        Room playersCurrentRoom = p.getRoom();
        CORE.destroyRoom(playersCurrentRoom.getRoomTrigger());
        this.thePlayer.setRoom(this); //let the player know they're in a new room
    }

    public void setEnemy(Enemy e)
    {
        this.theEnemy = e;
        this.theEnemy.setRoom(this);
    }

    public Player getPlayer()
    {
        return this.thePlayer;
    }   

    public GameObject getRoomTrigger()
    {
        return this.currentRoomTrigger;
    }
}
