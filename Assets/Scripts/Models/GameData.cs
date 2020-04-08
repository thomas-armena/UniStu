using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameData
{ 
    public static GameData Instance = new GameData();
    public CharacterAppearance CharacterAppearance { get; set; }
    public Stats CharacterStats { get; set; }
    public Time CurrentTime { get; set; }

    private GameData()
    {
        CharacterAppearance = new CharacterAppearance();
        CharacterStats = new Stats();
        CurrentTime = new Time();
    }

    public void saveGameData()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        // Save Character Appearance
        string cpath = Application.persistentDataPath + "/UniStu.CharacterAppearance";
        FileStream cstream = new FileStream(cpath, FileMode.Create);
        formatter.Serialize(cstream, this.CharacterAppearance);
        cstream.Close();

        // Save Character Stats
        string spath = Application.persistentDataPath + "/UniStu.CharacterStats";
        FileStream sstream = new FileStream(spath, FileMode.Create);
        formatter.Serialize(sstream, this.CharacterStats);
        sstream.Close();

        //Save Time stats
        string tpath = Application.persistentDataPath + "/UniStu.Time";
        FileStream tstream = new FileStream(tpath, FileMode.Create);
        formatter.Serialize(tstream, this.CurrentTime);
        tstream.Close();
    }

    public bool loadGameData()
    {
        string cpath = Application.persistentDataPath + "/UniStu.CharacterAppearance";
        string spath = Application.persistentDataPath + "/UniStu.CharacterStats";
        string tpath = Application.persistentDataPath + "/UniStu.Time";

        if (File.Exists(cpath) & File.Exists(spath) & File.Exists(tpath))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            // Load Character Appearance
            FileStream cstream = new FileStream(cpath, FileMode.Open);
            CharacterAppearance cdata = formatter.Deserialize(cstream) as CharacterAppearance;
            cstream.Close();
            Instance.CharacterAppearance = cdata;

            // Load Character Stats
            FileStream sstream = new FileStream(spath, FileMode.Open);
            Stats sdata = formatter.Deserialize(sstream) as Stats;
            sstream.Close();
            Instance.CharacterStats = sdata;

            // Load Time stats
            FileStream tstream = new FileStream(tpath, FileMode.Open);
            Time tdata = formatter.Deserialize(tstream) as Time;
            tstream.Close();
            Instance.CurrentTime = tdata;

            return true; // Successful Load
        } else
        {
            Debug.Log("Save files not found");
            return false; // Files not found so could not load files
        }
    }

    public void resetGame()
    {
        CharacterAppearance = new CharacterAppearance();
        CharacterStats = new Stats();
        CurrentTime = new Time();
    }

}