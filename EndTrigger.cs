<<<<<<< HEAD
﻿using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;



    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Done!!");
        gameManager.CompleteLevel();
    }

}
=======
﻿using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Done!!");
        gameManager.CompleteLevel();
    }

}
>>>>>>> 141f62bd46554ab52206fb4b99fffb7aa48d87d8
