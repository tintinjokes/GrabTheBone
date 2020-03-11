using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    public float cameraChangeSpeed = 2;
    private Transform custompos;

    Vector3 maincamerapos, transitionCamera;
    Transform tr;
    bool maincampos;

    public float smooth = 4;
    public float min = 2;
    public float max = 15;
    public float targetO;

    void Start()
    {
        tr = transform;
        maincamerapos = tr.position;
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Converting Mouse Pos to 2D (vector2) World Pos
            Vector2 rayPos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, -10f);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

            if (hit)
            {
                custompos = hit.transform;
                Debug.Log(hit.transform.name);

                Debug.Log(custompos);
            }

            if (maincampos == false)
            {
                maincampos = true;
                tr.parent = custompos;
            }
            else
            {
                maincampos = false;
                tr.parent = null;
            }
            Debug.Log(tr.parent);
        }

        // transition to dog
        if (maincampos == true)
        {
            //transitionCamera = custompos.position;
            transitionCamera = new Vector3(custompos.position.x + 3, custompos.position.y, -10f);

            targetO = Mathf.Clamp(targetO, min, max);
            Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, targetO, smooth * Time.deltaTime);
        }

        else transitionCamera = maincamerapos;

        // transition to main camera position
        if (tr.position != transitionCamera)
        {
            tr.position = Vector3.MoveTowards(tr.position, transitionCamera, Time.deltaTime * cameraChangeSpeed);

            targetO = Mathf.Clamp(targetO, min, max);
            Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, 5, smooth * Time.deltaTime);
        }
    }
}