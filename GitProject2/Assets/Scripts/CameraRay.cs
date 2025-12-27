using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;

public class CameraRay : MonoBehaviour
{
    public GameObject prop;
    public LayerMask mask;
    public LayerMask propMask;
    private float chekRadius = 1.5f;

    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            UnityEngine.Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, mask))
            {


                Collider[] props = Physics.OverlapSphere(hit.point, chekRadius, propMask);

                if (props.Length == 0)
                {
                    Instantiate(prop, hit.point, Quaternion.identity, hit.transform);
                }
                else
                {
                    Debug.Log("уси ре б пнр ю ме кнбсьйю");
                }
            }
        }
    }
}
