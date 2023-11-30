using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalmonHarvest : MonoBehaviour
{
    public AudioSource sonido;
    public AudioClip collectSound;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update(){
    }
    void OnTriggerEnter(Collider other){
        player.salmon++;
        gameObject.GetComponent<SphereCollider>().enabled=false;
        gameObject.GetComponent<MeshRenderer>().enabled=false;
        sonido.PlayOneShot(collectSound);
    }
}
