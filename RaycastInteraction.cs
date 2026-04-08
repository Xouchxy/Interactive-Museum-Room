using UnityEngine;

public class RaycastInteraction : MonoBehaviour
{
    public float interactDistance = 5f;
    public LayerMask interactLayer;
    private Interactable currentObject;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                if (currentObject != interactable)
                {
                    ClearCurrent();
                    currentObject = interactable;
                    currentObject.OnHover();
                }

                if (Input.GetMouseButtonDown(0))
                {
                    currentObject.OnClick();
                }
            }
        }
        else
        {
            ClearCurrent();
        }
    }

    void ClearCurrent()
    {
        if (currentObject != null)
        {
            currentObject.OnExit();
            currentObject = null;
        }
    }
}