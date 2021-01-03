using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public Gerakan movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "rintangan")
        {
            movement.enabled = false;
            FindObjectOfType<MyGameManager>().EndGame();

        }
    }
}
