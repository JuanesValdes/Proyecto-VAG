using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private static Respawn instance;
    public Transform respawn;
    

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);

        }

        else
        {
            Destroy(gameObject);
        }
    }

    void Start()


    {

        
        instance = null;

    }
}


