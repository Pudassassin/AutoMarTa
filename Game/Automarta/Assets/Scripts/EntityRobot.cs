using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Instructions;
using GameEntity;
using Automarta;

public class EntityRobot : MonoBehaviour
{
    //Entity Data
    public EntityObject entityObject;

    //Robot's internal Memory
    public Parameter memTemp;
    public Parameter[] memMain = new Parameter[RobotConstant.MAIN_MEM_SIZE];
    public List<Parameter>[] memList = new List<Parameter>[RobotConstant.LIST_MEM_SIZE];


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
