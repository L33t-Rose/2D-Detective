using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 position;
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void show() {
        print("called show");
        this.transform.position = position;
    }

    void hide() {
        print("called hide");

        var tmpPosition = this.transform.position;
        tmpPosition.y = -10.5f;

        this.transform.position = tmpPosition;


        print(this.transform.position);
    }
}
