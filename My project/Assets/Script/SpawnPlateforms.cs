using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlateforms : MonoBehaviour
{

    //Variable
    public GameObject Plateforms;
    public GameObject Pieces;

    public float timeBetweenSpawn;
    public float SpawnTime;

    public float maxX;
    public float maxY;
    public float minX;
    public float minY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > SpawnTime){

            Spawn();
            SpawnTime = Time.time + timeBetweenSpawn;

        }

    }

    void Spawn()
    {

        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY,maxY);

        float randomNombrePlatforms = Random.Range(1,3);
        float randomPieces = Random.Range(1,5);
            
        if(randomNombrePlatforms >= 2){
            
            Instantiate (Plateforms, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
            
            if(randomPieces >=3){

                Instantiate (Pieces, transform.position + new Vector3(randomX, randomY + 1, 0), transform.rotation);

            }
            

        }else{

            Instantiate (Plateforms, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
            Instantiate (Plateforms, transform.position + new Vector3(randomX, randomY + 3, 0), transform.rotation);  

            if(randomPieces >=3){

                Instantiate (Pieces, transform.position + new Vector3(randomX, randomY + 1, 0), transform.rotation);

            }else{

                Instantiate (Pieces, transform.position + new Vector3(randomX, randomY + 4, 0), transform.rotation);
            }
        }

    }
}
