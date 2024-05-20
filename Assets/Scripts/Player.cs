using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] public GameInput gameInput;    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola");
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement() {



    }

}
