using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] GameObject inventoryPanel, spellsPanel, notesPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddItem(GameObject panel) {
        Instantiate(item, panel.transform);
    }

    public void DeleteItem(GameObject btn) {
        Debug.Log(btn.transform.parent.gameObject);
    }
}
