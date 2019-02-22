using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : TacticsMove {

    bool shouldMoveThisFrame = false;

    // Use this for initialization
    void Start ()
    {
        Init();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawRay(transform.position, transform.forward);
        shouldMoveThisFrame = false;

        if(!moving)
        {
            FindSelectableTiles();
            CheckMouse();
        }
        else
        {
            shouldMoveThisFrame = true;
        }
	}

    //for Physics updates
    private void FixedUpdate()
    {
        if(shouldMoveThisFrame)
        {
            Move();
        }
    }

    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0)) //Left Click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "Tile")
                {
                    Tile t = hit.collider.GetComponent<Tile>();

                    if(t.selectable)
                    {
                        MoveToTile(t);
                    }
                }
            }
        }
    }
}
