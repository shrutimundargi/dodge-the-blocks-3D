using UnityEngine;

public class collision : MonoBehaviour
{
    public movement move;
    void OnCollisionEnter(Collision collisionObj)
    {
    	if (collisionObj.collider.tag == "obstacle")
    	{
    		move.enabled = false;
    		FindObjectOfType<manager>().GameOver();
    	} 
    }
}
