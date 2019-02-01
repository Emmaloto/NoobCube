using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
//using UnityEditor;

// Used for saving game data accross scenes
public class GameController : MonoBehaviour {

    public Material skin;

    public static GameController control;

    private void Awake()
    {
        //skin = (Material)AssetDatabase.LoadAssetAtPath("Assets/Photos + Mats/Materials/PlayerMat default.mat", typeof(Material));
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    // For the booleans
    public void SaveShopData(bool[] listToSave)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData(listToSave);

        bf.Serialize(file, data);
        file.Close();
    }

    // For the entire list
    public void SaveShopData(List<Item> listToSave)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData(listToSave);

        bf.Serialize(file, data);
        file.Close();
    }

    public List<Item> LoadShopData(List<Item> defaultList)
    {
        // List<Item> listToReturn = defaultList;
        

        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            bool[] valuesInStorage = data.values;

            // If we have enough values in storage
            if(valuesInStorage.Length >= defaultList.Count)
            {
                for (int i = 0; i < defaultList.Count; i++)
                {
                    defaultList[i].isOwned = valuesInStorage[i];
                }
            }
        }

        return defaultList;

    }
}

// Player Data wrapper class. Stuff to save to file goes here
[System.Serializable]
class PlayerData
{
    public bool[] values;

    public PlayerData(List<Item> list) {
        values = new bool[list.Count];

        for (int i = 0; i < values.Length; i++)
        {
            values[i] = list[i].isOwned;
        }
    }

    public PlayerData(bool[] valueList)
    {
        values = valueList;
    }
}