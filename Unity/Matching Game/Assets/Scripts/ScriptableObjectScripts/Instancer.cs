using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;

    private int num = 0;
    public void createInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }
    
    public void CreateInstanceFromList(Vector3DataList obj)
    {
        for (var i = 0; i < obj.Vector3Datas.Count; i++)
        {
            Instantiate(prefab,obj.Vector3Datas[i].value , Quaternion.identity);
        }
        
    }
    
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.Vector3Datas[num].value, Quaternion.identity);
        num++;
        if (num == obj.Vector3Datas.Count)
        {
            num = 0;
        }

    }
    
    public void CreateInstanceFromListRandom(Vector3DataList obj)
    {
        num = Random.Range(0, obj.Vector3Datas.Count - 1);
        Instantiate(prefab, obj.Vector3Datas[num].value, Quaternion.identity);

    }
   
}
