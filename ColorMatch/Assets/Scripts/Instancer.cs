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

}
