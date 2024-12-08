using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaController : MonoBehaviour
{
    public UIManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 0)
        {
            manager.background.gameObject.SetActive(true);
            // Wyswietlamy background koncowy
        }
    }
}
