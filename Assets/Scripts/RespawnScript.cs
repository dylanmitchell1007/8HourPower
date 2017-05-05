using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour {
    public void SpawnPoint()
    {
        Player.transform.position = Spawn.transform.position;
        
    }
    public void Point()
    {
        CheckPoint.transform.position = Spawn.transform.position;
    }
    public GameObject Player;
    public GameObject Spawn;
    public GameObject CheckPoint;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            Point();
            SpawnPoint();
            print("Ass");
            //Debug.Log(Player.GetComponent<MovementBehaviour>().spawn);
            
           
        }
    }
}
