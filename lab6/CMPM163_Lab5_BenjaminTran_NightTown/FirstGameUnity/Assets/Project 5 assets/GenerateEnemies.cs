//used Jimmy Vegas's video on generating random enemies as reference : https://www.youtube.com/watch?v=ydjpNNA5804

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{

	public GameObject theEnemy;
	public int xPos;
	public int zPos;
	public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
    	while (enemyCount < 100) 
    	{
    		xPos = Random.Range(1, 12);
    		zPos = Random.Range(1, 10);
    		Instantiate(theEnemy, new Vector3(xPos, .537f, zPos), Quaternion.identity);
    		yield return new WaitForSeconds(1);
    		enemyCount += 1;
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
