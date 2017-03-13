using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {

    public GameObject playerLeft;
    public GameObject playerRight;

    public GameObject plane;

    float margin = 0f;

	// Use this for initialization
	void Start () {
        CreateMap(5, 10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateMap(int _y, int _x)
    {
        for(int iz = 0; iz < _y; iz++)
        {
            for(int ix = 0; ix < _x; ix++)
            {
                Instantiate(plane, new Vector3(ix, 0f, iz + iz*margin), Quaternion.Euler(0f, 0f, 0f));
            }
        }
        Instantiate(playerLeft, new Vector3(-1, 0f, 0f), Quaternion.Euler(0f, 0f, 0f));
        Instantiate(playerRight, new Vector3(_x, 0f, 0f), Quaternion.Euler(0f, 0f, 0f));  
    }
    
}
