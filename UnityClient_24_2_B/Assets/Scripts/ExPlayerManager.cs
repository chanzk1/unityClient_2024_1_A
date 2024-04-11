using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ExItem
{
    public bool IsCollected;
}

public class ExPlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<ExItem> collectedItem = new List<ExItem>();

    void Start()
    {
        collectedItem.Add(new ExItem());
        collectedItem.Add(new ExItem());
        collectedItem[0].IsCollected = true;
        collectedItem[1].IsCollected = false;
        CheckAllItemsCollected();
    }

    // Update is called once per frame
    void CheckAllItemsCollected()
    {
        if(collectedItem.All(item => item.IsCollected))
        {
            Debug.Log("All items colleceted");
        }
    else
        {
            Debug.Log("NOt all items collected!");
        }
    }
}
