using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public bool playerRight = false;
    public int position = 0;
    public int maxPosition = 5;

    public GameObject[] soldiers;

    int pointerToSoldier = 0;
    GameObject pointerToSoldierPrefab;

    string str_player;
    Quaternion soldierRotation;

	// Use this for initialization
	void Start () {
        if(playerRight)
        {
            str_player = "P2";
            soldierRotation = Quaternion.Euler(-90f, 0f, 0f);
        }
        else
        {
            str_player = "P1";
            soldierRotation = Quaternion.Euler(-90f, 180f, 0f);
        }

        pointerToSoldierPrefab = Instantiate(soldiers[pointerToSoldier], transform.position, soldierRotation);
        pointerToSoldierPrefab.transform.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {
        ChangePosition();
        if (Input.GetButtonDown(str_player + "Back"))
        {
            ChangeSoldier();
        }

    }

    void ChangePosition()
    {
        if (Input.GetButtonDown(str_player + "Up"))
        {
            if(position < maxPosition-1)
            {
                position++;
            }
        }
        if (Input.GetButtonDown(str_player + "Down"))
        {
            if (position > 0)
            {
                position--;
            }
        }
        transform.position = new Vector3(transform.position.x, 0f, position);
    }

    void ChangeSoldier()
    {
        if(pointerToSoldier < soldiers.Length - 1)
        {
            pointerToSoldier++;
        }
        else
        {
            pointerToSoldier = 0;
        }

        Destroy(pointerToSoldierPrefab);
        pointerToSoldierPrefab = Instantiate(soldiers[pointerToSoldier], transform.position, soldierRotation);
        pointerToSoldierPrefab.transform.parent = transform;

    }
}
