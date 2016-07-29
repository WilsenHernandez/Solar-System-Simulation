using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour
{

    static public GameObject target; // the target that the camera should look at
    public GameObject startingObject;

    void Start ()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");
        }

        if (startingObject != null)
            transform.LookAt(startingObject.transform);
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (target)
            transform.LookAt(target.transform);
    }
}
