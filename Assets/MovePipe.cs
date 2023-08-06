using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // deltaTime: 지난 frame이 완료되는 데 걸리는 시간, 어떤 fps여도 동일한 경험 제공
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
