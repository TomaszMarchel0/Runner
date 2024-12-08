using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public float moveSpeed; // zmienna okreslajaca z jaka predkoscia bedzie poruszac sie teren

    public float incrementSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = moveSpeed + incrementSpeed * Time.deltaTime;

        Vector3 moveVector = new Vector3(0, 0, -1); //wektor poruszania si�
        transform.Translate(moveVector * Time.deltaTime * moveSpeed); //przesuwanie obiektu po osi Z
    }
}