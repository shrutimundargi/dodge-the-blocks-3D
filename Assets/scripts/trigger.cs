using UnityEngine;

public class trigger : MonoBehaviour
{
    public manager mana;
    void OnTriggerEnter()
    {
    	mana.CompleteLevel(); 
    }
}
