using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeneratePlatform : MonoBehaviour
{
    public float spaceBetweenPlatforms = 5;
    public float playerHeight;
    public float platformHeight = 5;
    public GameObject platform;
    public GameObject player;


    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < 15; i++)
        {
            Instantiate(platform, new Vector3(((float)Random.value * 20) - 10, (float)platformHeight, 0f), Quaternion.identity);
            platformHeight += spaceBetweenPlatforms;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(platformHeight - player.transform.position.y <=15f || player.transform.position.y >150f)
        {
            Instantiate(platform, new Vector3(((float)Random.value * 20) - 10, (float)platformHeight, 0f), Quaternion.identity);
            platformHeight += spaceBetweenPlatforms;
            spaceBetweenPlatforms += 0.2f;
        }
	}
}
