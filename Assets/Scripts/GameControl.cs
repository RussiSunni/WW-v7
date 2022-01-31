using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    public Transform A1, A2, A3, B1, B2, B3, C1, C2, C3, D1, D2, D3, E1, E2, E3, F1, F2, F3, G1, G2, G3, H1, H2, H3;
    public Transform A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z;
    public List<Transform> Col1 = new List<Transform>();
    public List<Transform> Col2 = new List<Transform>();
    public List<Transform> Col3 = new List<Transform>();
    public List<Transform> Col4 = new List<Transform>();
    public List<Transform> Col5 = new List<Transform>();
    public List<Transform> Col6 = new List<Transform>();
    public List<Transform> Col7 = new List<Transform>();
    public List<Transform> Col8 = new List<Transform>();
    public List<List<Transform>> Cols = new List<List<Transform>>();
    public List<Transform> Row1 = new List<Transform>();
    public List<Transform> Row2 = new List<Transform>();
    public List<Transform> Row3 = new List<Transform>();
    public List<List<Transform>> Rows = new List<List<Transform>>();
    public static List<string> currentWords = new List<string>();
    public static List<DictionaryLookup> dictionaryLookupsList = new List<DictionaryLookup>();
    public static List<UserWords> userWordsList = new List<UserWords>();
    public static List<string> userWordNameList = new List<string>();
    public static UserDetails userDetails = new UserDetails();
    public static bool isNameExercise, isAgeExercise;
    string word;
    char[] board;

    public Animator fairyAnimator;


    void Start()
    {
        Col1.Add(A1);
        Col1.Add(A2);
        Col1.Add(A3);
        Col2.Add(B1);
        Col2.Add(B2);
        Col2.Add(B3);
        Col3.Add(C1);
        Col3.Add(C2);
        Col3.Add(C3);
        Col4.Add(D1);
        Col4.Add(D2);
        Col4.Add(D3);
        Col5.Add(E1);
        Col5.Add(E2);
        Col5.Add(E3);
        Col6.Add(F1);
        Col6.Add(F2);
        Col6.Add(F3);
        Col7.Add(G1);
        Col7.Add(G2);
        Col7.Add(G3);
        Col8.Add(H1);
        Col8.Add(H2);
        Col8.Add(H3);

        Cols.Add(Col1);
        Cols.Add(Col2);
        Cols.Add(Col3);
        Cols.Add(Col4);
        Cols.Add(Col5);
        Cols.Add(Col6);
        Cols.Add(Col7);
        Cols.Add(Col8);

        Row1.Add(A1);
        Row1.Add(B1);
        Row1.Add(C1);
        Row1.Add(D1);
        Row1.Add(E1);
        Row1.Add(F1);
        Row1.Add(G1);
        Row1.Add(H1);

        Row2.Add(A2);
        Row2.Add(B2);
        Row2.Add(C2);
        Row2.Add(D2);
        Row2.Add(E2);
        Row2.Add(F2);
        Row2.Add(G2);
        Row2.Add(H2);

        Row3.Add(A3);
        Row3.Add(B3);
        Row3.Add(C3);
        Row3.Add(D3);
        Row3.Add(E3);
        Row3.Add(F3);
        Row3.Add(G3);
        Row3.Add(H3);

        Rows.Add(Row1);
        Rows.Add(Row2);
        Rows.Add(Row3);

    }

    public void UpdateStage()
    {
        var fairy = GameObject.Find("Fairy");
        Fairy fairyScript = fairy.GetComponent<Fairy>();

        var subject = GameObject.Find("Subject");
        Subject subjectScript = subject.GetComponent<Subject>();

        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();

        // reset Fairy animation
        fairyScript.NoAnimation();

        // reset subject animation
        subjectScript.NoAnimation();

  
        // currentWords = words that have been made    

        // load current board
        // for 3 rows
        // Row 1
        char[] board1 = new char[8];
        for (int i = 0; i < 8; i++)
        {
            if (Row1[i].childCount > 0)
            {
                board1[i] = Row1[i].GetChild(0).gameObject.name[0];
            }
        }

        // Row 2
        char[] board2 = new char[8];
        for (int i = 0; i < 8; i++)
        {
            if (Row2[i].childCount > 0)
            {
                board2[i] = Row2[i].GetChild(0).gameObject.name[0];
            }
        }

        // Row 3
        char[] board3 = new char[8];
        for (int i = 0; i < 8; i++)
        {
            if (Row3[i].childCount > 0)
            {
                board3[i] = Row3[i].GetChild(0).gameObject.name[0];
            }
        }

        // for the exercise to find the name
        if (isNameExercise)
        {
            string nameString01 = new string(board1);
            string nameString02 = new string(board2);
            string nameString03 = new string(board3);
            //string nameString = nameString + nameString02 + nameString03;

            userDetails.Name = nameString01;
        }


        // for the exercise to find the age
        if (isAgeExercise)
        {
            string ageString01 = new string(board1);
            string ageString02 = new string(board2);
            string ageString03 = new string(board3);
            //string nameString = nameString + nameString02 + nameString03;

            userDetails.Age = ageString01;
        }

        // for other exercises or regular dictionary
        else
        {
            // for 3 rows
            // run the function      
            Search(board1, dictionaryLookupsList);
            Search(board2, dictionaryLookupsList);
            Search(board3, dictionaryLookupsList);

            // for this string in Current Words, use this
            for (int i = 0; i < currentWords.Count; i++)
            {
                foreach (var lookup in dictionaryLookupsList)
                {
                    if (currentWords[i] == lookup.Name)
                    {
                        // if word is a noun, and another object is on the screen
                        if (lookup.Subject)
                        {
                                subjectScript.Animation(lookup.AnimationClipParameter);
                                soundManagerScript.playSound(soundManagerScript.wordSoundList[lookup.AudioClipNumber]);

                                // Cat exercise 02 - Fairy saying thanks
                                if (Fairy.inCatExercise)
                                {
                                    if (lookup.Name == "CAT")
                                    {
                                        soundManagerScript.playSound(soundManagerScript.catExercise05);                                 
                                    }
                                }
                        }

                        // if word is a verb, or another word that does not require another object on the screen
                        else
                        {
                            // print(currentWords[i]);
                            // print(lookup.AnimationClipParameter);
                            fairyScript.Animation(lookup.AnimationClipParameter);
                            soundManagerScript.playSound(soundManagerScript.wordSoundList[lookup.AudioClipNumber]);
                        }

                       // print(lookup.Name);
                        // update user table in db
                        var ds = new DataService("DictionaryLookups.db");

                        if (!GameControl.userWordNameList.Contains(lookup.Name))
                            userWordsList.Add(ds.CreateUserWord(lookup.Name));

                        foreach (var uw in userWordsList)
                        {
                            print(uw.Name);
                            userWordNameList.Add(uw.Name);
                        }
                    }
                }
            }

            //RULES ----------------         
            currentWords.Clear();
        }
    }


    private bool Search(char[] board, List<DictionaryLookup> dictionaryLookupsList)
    {
        for (int i = 0; i < board.Length; i++)
        {
            foreach (DictionaryLookup dictionaryLookup in dictionaryLookupsList)
            {
                if (board[i] == dictionaryLookup.Name[0] && dfs(board, i, 0, dictionaryLookup.Name))
                {
                    //print(words[h]);
                }
            }
        }
        return false;
    }



    public bool dfs(char[] board, int i, int count, string word)
    {
        // print(word);

        if (count == word.Length)
            return true;

        if (i < 0 || i >= board.Length || board[i] != word[count])
            return false;


        char temp = board[i];
        board[i] = ' ';

        bool found = dfs(board, i + 1, count + 1, word);

        board[i] = temp;

        if (found && !currentWords.Contains(word))
        {
            currentWords.Add(word);
        }

        return found;
    }
}