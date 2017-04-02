using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour {

    public float speed = 0.01f;
    public int HP;
    private bool _encounterEnemy = false;


	// Use this for initialization
	void Start ()
    {
        transform.rotation = Quaternion.Euler(-90f, 180f, 0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Move();
        Life();
	}

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.GetComponent<SoldierController>())
        {
            _encounterEnemy = true;
            Attack();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        _encounterEnemy = false;
    }

    void Move()
    {
        if(!_encounterEnemy)
        {
            transform.position += new Vector3(speed, 0f, 0f);
            Debug.Log("Move");
        }
    }

    void Life()
    {
        if(HP <= 0f)
        {
            
        }
    }

    void Attack()
    {
        Debug.Log("Attack");
    }

    void DestroyEnemy()
    {
        Destroy(this);
        _encounterEnemy = false;
    } 
}
