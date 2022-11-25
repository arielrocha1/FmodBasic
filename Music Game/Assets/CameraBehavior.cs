using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {

    public GameObject player;
    [SerializeField]
    private float xAxis, yAxis, zAxis;
    
    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x + xAxis, player.transform.position.y + yAxis, player.transform.position.z + zAxis);
    }
}