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


    foreach (var item in obj.vector3DList)
    {
        Instantiate(prefab, item.value, Quaternion.identity);
    }    
   }

    public void CreateInstanceListRandomly(Vector3DataList obj)
   {
    num = Random.Range(0, obj.vector3DList.Count - 1);
    Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
   }    
}
