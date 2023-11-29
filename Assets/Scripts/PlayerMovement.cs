using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed=15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  void Update(){
        MoverGato();
    }

    public void MoverGato(){
        float moveX=Input.GetAxis("Horizontal");
        float moveZ=Input.GetAxis("Vertical");
        Vector3 movement=new Vector3(moveX,0,moveZ).normalized;
        transform.Translate(movement*speed*Time.deltaTime);
    }
}
