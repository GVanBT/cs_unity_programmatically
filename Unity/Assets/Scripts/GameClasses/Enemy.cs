using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy
{
//maak hier public class variables:
	//1 (acces=public, Type= GameObject, name=obj)
    public GameObject obj;

	//2 (acces=public, Type= int, name=from)
    public int from;

	//3 (acces=public, Type= int, name=to)
    public int to;
    private GameObject enemyObj;

    public Enemy(GameObject enemyObj)
    {
        this.enemyObj = enemyObj;
    }

    public Enemy(GameObject obj, int from, int to)///verander hier iets zodat je een GameObject met de constructor kan meegeven
    {
        this.obj = obj;
        this.from = from;
        this.to = to;
    }

}