using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{ 
    public Selectable CurrentSelectable;

    void LateUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("first");
            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable)
            {
                if (CurrentSelectable && CurrentSelectable != selectable)
                {
                    CurrentSelectable.DeSelect();
                }
                    CurrentSelectable = selectable;
                    selectable.Select();
            }
            else
            {
                if (CurrentSelectable)
                {
                    CurrentSelectable.DeSelect();
                    CurrentSelectable = null;
                }
            } 
        }
        else
        {
            if (CurrentSelectable)
            {
                CurrentSelectable.DeSelect();
                CurrentSelectable = null;
            }
        }
    }
}
