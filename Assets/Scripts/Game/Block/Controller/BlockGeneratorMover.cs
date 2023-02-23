using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class BlockGeneratorMover : MonoBehaviour
{
    [SerializeField] int size;
    int limit;

    //--------------------------------------------------

    void Awake()
    {
        limit = Mathf.FloorToInt(size / 2);
    }

    void Update()
    {
        
    }

    public void Pushed()
	{

	}

    public void MoveLeft()
	{
        if(transform.position.x>-limit)
        transform.position += Vector3.left;
	}

    public void MoveRight()
	{
        if(transform.position.x<limit)
        transform.position += Vector3.right;
	}
}
