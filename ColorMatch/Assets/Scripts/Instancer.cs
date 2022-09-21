using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;

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
    foreach (var i = 0; i < obj.vector3DList.Count; i++)
    {
        Instantiate(prefab, obj.vector3DList[i].value, Quaternion.identity);
    }    
   }
}
