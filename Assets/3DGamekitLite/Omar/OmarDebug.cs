using Gamekit3D;
using UnityEngine;

public class OmarDebug : MonoBehaviour
{

    [SerializeField] PlayerController playerController;
    [SerializeField] Damageable damageable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            playerController.canAttack = !playerController.canAttack;
            Debug.Log(playerController.canAttack);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if(playerController.maxForwardSpeed == 8)
            {
                playerController.maxForwardSpeed = 16;
            }
            else
            {
                playerController.maxForwardSpeed = 8;
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            damageable.ResetDamage();
        }
    }
}
