using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {


	// fields
	[SerializeField]
	protected GameObject[] nuts;

	// Use this for initialization
	void Start () {
		fallingNuts1();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// hardcoded: randomly HazelNuts fall
	void fallingNuts1()
	{
		dropNut(1);
		dropNut(0);
		dropNut(5);
		dropNut(11);
		StartCoroutine(Wait1());
	}
	void fallingNuts2()
	{
		dropNut(7);
		dropNut(14);
		dropNut(4);
		dropNut(2);
		dropNut(13);
		StartCoroutine(Wait2());
	}
	void fallingNuts3()
	{
		dropNut(3);
		dropNut(6);
		dropNut(8);
		dropNut(9);
		dropNut(10);
		dropNut(12);
	}
	IEnumerator Wait1()
	{
        yield return new WaitForSeconds(3);
		fallingNuts2();
    }
	IEnumerator Wait2()
	{
        yield return new WaitForSeconds(3);
		fallingNuts3();
    }
	
	void dropNut(int i)
	{
		nuts[i].GetComponent<Rigidbody>().useGravity = true;
	}
}
