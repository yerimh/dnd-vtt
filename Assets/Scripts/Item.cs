using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField] TMP_InputField itemNameInput;
    private string itemName;
    private int quantity;
    private bool isMagical;
    private string notes;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        itemName = itemNameInput.text;
    }

    public Item(string item) {
        itemName = item;
    }
}
