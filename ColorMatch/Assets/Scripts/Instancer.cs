using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;

   public void CreateInstance ()
   {
    Instantiate(prefab);
   }

   public void CreateInstance (Vector3Data obj)
   {
    Instantiate(prefab, obj.value, Quaternion.identity);
   }

   public void CreateInstanceFromList(Vector3DataList obj)
   {
    foreach (var t:Vector3Data in obj.vector3DList)
    {
        Instantiate(prefab, t.value, Quaternion.identity);
    }    
   }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
   {
    Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
    num++;
    if(num == obj.vector3DList.Count)
    {
        num = 0;
    }
   }    
}
