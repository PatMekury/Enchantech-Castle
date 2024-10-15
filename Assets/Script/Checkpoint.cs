using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject checkpoint;
    public bool isActive;
    public float positionx;
    public float positiony;
    public float positionz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCheckpoint()
    {
        if (isActive)
        {
            checkpoint.SetActive(true);
            checkpoint.transform.position = new Vector3(positionx, positiony, positionz);
            checkpoint.transform.rotation = Quaternion.Euler(0, 0, 0);

        }

        if (!isActive)
        {
            checkpoint.SetActive(false);
            checkpoint.transform.position = new Vector3(0, 0, 0);
            checkpoint.transform.rotation = Quaternion.Euler(0, 0, 0);

        }
    }
}
