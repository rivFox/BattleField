using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public bool playerRight = false;
    public int maxPosition = 5;
    private int _position = 0;

    public GameObject[] soldiers;

    private int _pointerToSoldier = 0;
    GameObject pointerToSoldierPrefab;

    string str_player;

	// Use this for initialization
	void Start () {
        if(playerRight)
        {
            str_player = "P2";
        }
        else
        {
            str_player = "P1";
        }

        pointerToSoldierPrefab = Instantiate(soldiers[_pointerToSoldier], transform.position, transform.rotation);
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
            if(_position < maxPosition-1)
            {
                _position++;
            }
        }
        if (Input.GetButtonDown(str_player + "Down"))
        {
            if (_position > 0)
            {
                _position--;
            }
        }
        transform.position = new Vector3(transform.position.x, 0f, _position);
    }

    void ChangeSoldier()
    {
        if(_pointerToSoldier < soldiers.Length - 1)
        {
            _pointerToSoldier++;
        }
        else
        {
            _pointerToSoldier = 0;
        }

        Destroy(pointerToSoldierPrefab);
        pointerToSoldierPrefab = Instantiate(soldiers[_pointerToSoldier], transform.position, transform.rotation);
        pointerToSoldierPrefab.transform.parent = transform;

    }
}
