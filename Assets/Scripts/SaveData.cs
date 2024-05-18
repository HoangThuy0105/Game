using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SaveData 
{
    public int m_scorel;

    public string ToJson()
    {
        return JsonUtility.ToJson(this);
    }

    public void LoadFromJson (string a_Json)
    {
        JsonUtility.FromJsonOverWrite(a_Json, this);
    }
}
priavte static void SaveJsonData(GameViewController a_GameViewController)
{
    saveData sd = new SaveData;
    //a_GameViewController.PopulateSaveData(sd);

    if (FileManager.WriteToFile("SaveData.dat", sd.ToJson);
    {
        Debug.Log("Save successful"):
}

public interface ISaveable
{
    void PopulateData(SaveData a_SaveData);
    void LoadFromSaveData(SaveData a_SaveData);
}
