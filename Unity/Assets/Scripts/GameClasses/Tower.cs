using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

//class make oefening
public class Tower
{
//maak hier public class variables:
	//1  (acces=public, Type= GameObject, name=obj)
    public GameObject obj;

	//2 (acces=public, Type= GameObject, name=onTile)
    public GameObject onTile;

	//3 (acces=public, Type= float, name=detectRange)
    public float detectRange;
    private GameObject towerObj;
    private int v;

    public Tower(GameObject obj, GameObject onTile, float detectRange) //verander hier iets zodat je alle variablen mee kan geven aan de constructor
    { //volgorde: obj, detectRange,onTile
        this.obj = obj;
        this.onTile = onTile;
        this.detectRange = detectRange;
    }

    public Tower(GameObject towerObj, int v, GameObject onTile)
    {
        this.towerObj = towerObj;
        this.v = v;
        this.onTile = onTile;
    }
}
