using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {
    public Transform exit;
    public Transform last;

    void OnTriggerEnter(Collider obj)
    {
        if (exit == last)
            return;

        TeleportToExit(obj);
    }

    void OnTriggerExit()
    {
        if (exit == last)
            last = null;
    }

    void TeleportToExit(Collider obj)
    {   
        last = transform;
        obj.transform.position = exit.transform.position;
    }
}
