using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectManager : MonoBehaviour
{
    public GameObject selectedObject;
    public TextMeshProUGUI objNameText;
    private BuildingManager buildingManager;
    public GameObject objUI;
    public Button colorButton;

    void Start()
    {
        buildingManager = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000)) {
                if (hit.collider.gameObject.CompareTag("Object")) {
                    Select(hit.collider.gameObject);
                }
            }
        }

        if (Input.GetMouseButtonDown(1) && selectedObject != null) {
            Deselect();
        }
    }

    private void Select(GameObject obj)
    {
        if (obj == selectedObject)
            return;
        if (selectedObject != null)
            Deselect();
        Outline outline = obj.GetComponent<Outline>();
        if (outline == null)
            obj.AddComponent<Outline>();
        else
            outline.enabled = true;
        objNameText.text = obj.name;
        objUI.SetActive(true);
        selectedObject = obj;
    }

    private void Deselect()
    {
        objUI.SetActive(false);
        selectedObject.GetComponent<Outline>().enabled = false;
        selectedObject = null;
    }

    public void Move()
    {
        buildingManager.pendingObject = selectedObject;
    }

    public void Delete()
    {
        GameObject objToDestroy = selectedObject;
        Deselect();
        Destroy(objToDestroy);
    }

    public void ChangeColour()
    {
        if (selectedObject == null)
            return;

        Color randomColor = new Color(Random.value, Random.value, Random.value);

        Renderer renderer = selectedObject.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = randomColor;
        }

        ChangeButtonColor(randomColor);
    }

    private void ChangeButtonColor(Color color)
    {
        ColorBlock cb = colorButton.colors;
        cb.normalColor = color;
        cb.selectedColor = color;
        cb.highlightedColor = color;
        cb.pressedColor = color;
        colorButton.colors = cb;
    }
}
