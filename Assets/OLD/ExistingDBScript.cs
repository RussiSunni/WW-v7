using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ExistingDBScript : MonoBehaviour
{
    public Text DebugText;

    void Start()
    {
        // Dictionary Lookups
        var ds = new DataService("DictionaryLookups.db");
        var dictionaryLookups = ds.GetDL();
        ToConsole(dictionaryLookups);

        // Users
     //   var user = ds.GetUserWords();
      //  ToConsole2(user);


#if UNITY_EDITOR
        ds.TruncateUserWords();
#endif

    }

    private void ToConsole(IEnumerable<DictionaryLookup> dictionaryLookups)
    {
        foreach (var dictionaryLookup in dictionaryLookups)
        {
            //  ToConsole(dictionaryLookup.ToString());
            //GameControl.dictionaryLookups.Add(dictionaryLookup.Name, dictionaryLookup.Sprite);
            GameControl.dictionaryLookupsList.Add(dictionaryLookup);

     //       ToConsole(dictionaryLookup.ToString());
        }

        
    }

   // private void ToConsole(string msg)
   // {
        // DebugText.text += System.Environment.NewLine + msg;
        // Debug.Log(msg);
   // }

   // private void ToConsole2(IEnumerable<UserWords> userWords)
   // {
    //    foreach (var userWord in userWords)
     //   {
       //     GameControl.userWordsList.Add(userWord);
            // foreach (var uw in GameControl.userWordsList)
            // {
            //     print(uw.Name);
            // }
      //  }
   // }
}
