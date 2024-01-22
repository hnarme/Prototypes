using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void Save (LevelIdentifier levelIdentifier, PlayerController playerController, HealthManager healthManager, EnemyController enemyController, EnemyHealthManager enemyHealthManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/SaveData";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData(levelIdentifier, playerController, healthManager, enemyController, enemyHealthManager);

        formatter.Serialize(stream, data);
        Debug.Log("Game Saved! Save file found in " + path);
        stream.Close();
    }

    public static SaveData Load()
    {
        string path = Application.persistentDataPath + "/SaveData";

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data = formatter.Deserialize(stream) as SaveData;
            stream.Close();

            return data;
        } else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
