using UnityEngine;
using System.Collections;

public class Salmon : MonoBehaviour {

    public Player player;

    void Start(){
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

	void Update (){

    }


}