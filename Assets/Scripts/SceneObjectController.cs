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
        print("This is the original pos"+original_position);
    }

    // Update is called once per frame
    void show() {
        print("called show");
        print(original_position);
        transform.position = original_position;
        print(this.transform.position);
    }

    void hide() {
        print("called hide"+this.name);

        var tmpPosition = this.transform.position;
        tmpPosition.y = -10.5f;

        this.transform.position = tmpPosition;


        print(this.transform.position);
    }
}
