using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    private static List<GameObject> theRoomsGos = new List<GameObject>();
    private static List<GameObject> theRoomTriggers = new List<GameObject>();
    private static List<Room> theRooms = new List<Room>();
    private static Player currentPlayer = null;
    private static Enemy currentEnemy = null;

    public static GameObject getRoom()
    {
        return CORE.theRoomsGos[0];
    }

    public static void setPlayer(Player p)
    {
        CORE.currentPlayer = p;
    }

    public static void setEnemy(Enemy e)
    {
        CORE.currentEnemy = e;
    }

    public static Player getPlayer()
    {
        return CORE.currentPlayer;
    }

    public static Enemy getEnemy()
    {
        return CORE.currentEnemy;
    }

    public static void destroyRoom(GameObject g)
    {
        Destroy(CORE.theRoomsGos[theRoomTriggers.IndexOf(g)]);
    }

    public static void addRoom(Room theRoom)
    {
        CORE.theRooms.Add(theRoom);
    }

    public static void addRoomGO(GameObject go)
    {
        CORE.theRoomsGos.Add(go);
    }

    public static void addRoomTrigger(GameObject g)
    {
        CORE.theRoomTriggers.Add(g);
    }

    public static void display()
    {

    }
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
