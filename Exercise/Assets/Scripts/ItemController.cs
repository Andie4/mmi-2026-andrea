using System;
using UnityEngine;
using UnityEngine.Assertions;

public class ItemController : TriggerController
{
    private static readonly int INVALID_ID = 0;

    [SerializeField] private GameObject m_Item;
// --> pas trop compris pour le SerializeField 

    public int UniqueID { get; private set; } = INVALID_ID;
    // pourquoi ne pas directement initailiser UniqueID à 0 ? 

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

// le code repris sur le repo est dans cet ordre mais il faudrait le mettre avant interact non ? Au dessus pickitem n'existe pas encore pourtant il est appelé 
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
