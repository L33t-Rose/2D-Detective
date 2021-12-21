using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 original_position;
    void Start()
    {
        original_position = transform.position;
    }

    // Update is called once per frame
    void show() {
        print(original_position);
        transform.position = original_position;
        print(this.transform.position);
    }

    void hide() {

        var tmpPosition = this.transform.position;
        tmpPosition.y = -10.5f;

        this.transform.position = tmpPosition;

    }
}
