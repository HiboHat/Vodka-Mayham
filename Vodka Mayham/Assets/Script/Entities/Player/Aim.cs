using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Aim : MonoBehaviour
{
    private Vector3 aimDirection;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        aimDirection = ((Vector2)InputListener.MouseScreenPosition() - (Vector2)transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
