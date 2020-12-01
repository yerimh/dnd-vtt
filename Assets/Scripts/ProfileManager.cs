using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/**
 * TODO: Item class is monobehaviour. Either attach it to each clone, or have it be its own thing for data collection
 */
public class ProfileManager : MonoBehaviour
{
    [SerializeField] GameObject itemContainer;
    [SerializeField] GameObject inventoryPanel, spellsPanel, notesPanel;
    private List<Item> inventory = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddItem(GameObject panel) {
        GameObject newItemContainer = Instantiate(itemContainer, panel.transform);
        Button delete = newItemContainer.GetComponentInChildren<Button>();
        delete.onClick.AddListener(DeleteItem);

        // inventory.Add(new Item(itemContainer.GetComponentInChildren<TMP_InputField>().text));
    }

    public void DeleteItem() {
        GameObject deleting = EventSystem.current.currentSelectedGameObject;
        Destroy(deleting.transform.parent.gameObject);
    }
}
