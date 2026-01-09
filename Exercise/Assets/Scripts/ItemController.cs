using System;
using UnityEngine;
using UnityEngine.Assertions;

public class ItemController : TriggerController
{
    private static readonly int INVALID_ID = 0;

    [SerializeField] private GameObject m_Item;

    public int UniqueID { get; private set; } = INVALID_ID;

    private void Awake()
    {
        Assert.IsNotNull(m_Item, "Please assign a valid GameObject to the item member.");

        UniqueID = m_Item.GetInstanceID();
    }

    protected override void Interact()
    {
        PickItem();

        CanInteract = false;
    }

    private void PickItem()
    {
        //TODO: Replace this with the correct implementation
        // throw new NotImplementedException("PickItem method is yet not implemented.");

        //TODO: Store the item into the InventorySystem instance
        InventorySystem.Instance.StoreItem(UniqueID);

        //TODO: Disable interaction from Trigger
        CanInteract = false;

        //TODO: Deactivate item GameObject
        m_Item.SetActive(false);

    }
}
