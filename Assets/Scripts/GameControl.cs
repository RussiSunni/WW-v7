using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    public Transform A1, B1,C1, D1, E1, F1,  G1, H1;    
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
    public List<List<Transform>> Rows = new List<List<Transform>>();
    public static List<string> currentWords = new List<string>();
    public static List<DictionaryLookup> dictionaryLookupsList = new List<DictionaryLookup>();
    public static List<UserWords> userWordsList = new List<UserWords>();
    public static List<string> userWordNameList = new List<string>();
    public static UserDetails userDetails = new UserDetails();
    public static bool isNameExercise, isAgeExercise;
    string word;
    char[] board;
    public List<DictionaryLookup> dictionaryLookups = new List<DictionaryLookup>();

    public Animator fairyAnimator;

    void Start()
    {
        Col1.Add(A1);        
        Col2.Add(B1);        
        Col3.Add(C1);        
        Col4.Add(D1);        
        Col5.Add(E1);        
        Col6.Add(F1);        
        Col7.Add(G1);        
        Col8.Add(H1);        
        
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

        // Populate the list of recorded words.
        var jump = new DictionaryLookup();
        jump.Id = 1;
        jump.Name = "JUMP";
        jump.AnimationClipParameter = "isJump";
        jump.Subject = false;
        jump.AudioClipNumber = 0;
        dictionaryLookups.Add(jump);

        var hello = new DictionaryLookup();
        hello.Id = 2;
        hello.Name = "HELLO";
        hello.AnimationClipParameter = "isHello";
        hello.Subject = false;
        hello.AudioClipNumber = 1;
        dictionaryLookups.Add(hello);

        var sit = new DictionaryLookup();
        sit.Id = 3;
        sit.Name = "SIT";
        sit.AnimationClipParameter = "isSit";
        sit.Subject = false;
        sit.AudioClipNumber = 2;
        dictionaryLookups.Add(sit);

        var cat = new DictionaryLookup();
        cat.Id = 4;
        cat.Name = "CAT";
        cat.AnimationClipParameter = "isCat";
        cat.Subject = true;
        cat.AudioClipNumber = 3;
        dictionaryLookups.Add(cat);

        var bus = new DictionaryLookup();
        bus.Id = 5;
        bus.Name = "BUS";
        bus.AnimationClipParameter = "isBus";
        bus.Subject = false;
        bus.AudioClipNumber = 4;
        dictionaryLookups.Add(bus);

        var tail = new DictionaryLookup();
        tail.Id = 6;
        tail.Name = "TAIL";
        tail.AnimationClipParameter = "isTail";
        tail.Subject = false;
        tail.AudioClipNumber = 5;
        dictionaryLookups.Add(tail);

        var night = new DictionaryLookup();
        night.Id = 7;
        night.Name = "NIGHT";
        night.AnimationClipParameter = "isNight";
        night.Subject = false;
        night.AudioClipNumber = 6;
        dictionaryLookups.Add(night);

        var queen = new DictionaryLookup();
        queen.Id = 8;
        queen.Name = "QUEEN";
        queen.AnimationClipParameter = "isQueen";
        queen.Subject = false;
        queen.AudioClipNumber = 7;
        dictionaryLookups.Add(queen);

        var salt = new DictionaryLookup();
        salt.Id = 9;
        salt.Name = "SALT";
        salt.AnimationClipParameter = "isSalt";
        salt.Subject = false;
        salt.AudioClipNumber = 8;
        dictionaryLookups.Add(salt);

        var umbrella = new DictionaryLookup();
        umbrella.Id = 10;
        umbrella.Name = "UMBRELLA";
        umbrella.AnimationClipParameter = "isUmbrella";
        umbrella.Subject = false;
        umbrella.AudioClipNumber = 9;
        dictionaryLookups.Add(umbrella);

        var astronaut = new DictionaryLookup();
        astronaut.Id = 11;
        astronaut.Name = "ASTRONAUT";
        astronaut.AnimationClipParameter = "isAstronaut";
        astronaut.Subject = false;
        astronaut.AudioClipNumber = 10;
        dictionaryLookups.Add(astronaut);

        var blond = new DictionaryLookup();
        blond.Id = 12;
        blond.Name = "BLOND";
        blond.AnimationClipParameter = "isBlond";
        blond.Subject = false;
        blond.AudioClipNumber = 11;
        dictionaryLookups.Add(blond);

        var dog = new DictionaryLookup();
        dog.Id = 13;
        dog.Name = "DOG";
        dog.AnimationClipParameter = "isDog";
        dog.Subject = true;
        dog.AudioClipNumber = 12;
        dictionaryLookups.Add(dog);

        var upset = new DictionaryLookup();
        upset.Id = 14;
        upset.Name = "UPSET";
        upset.AnimationClipParameter = "isUpset";
        upset.Subject = false;
        upset.AudioClipNumber = 13;
        dictionaryLookups.Add(upset);

        var rain = new DictionaryLookup();
        rain.Id = 15;
        rain.Name = "RAIN";
        rain.AnimationClipParameter = "isRain";
        rain.Subject = false;
        rain.AudioClipNumber = 14;
        dictionaryLookups.Add(rain);

        var hi = new DictionaryLookup();
        hi.Id = 16;
        hi.Name = "HI";
        hi.AnimationClipParameter = "isHi";
        hi.Subject = false;
        hi.AudioClipNumber = 15;
        dictionaryLookups.Add(hi);

        var turn = new DictionaryLookup();
        turn.Id = 17;
        turn.Name = "TURN";
        turn.AnimationClipParameter = "isTurn";
        turn.Subject = false;
        turn.AudioClipNumber = 16;
        dictionaryLookups.Add(turn);

        var hat = new DictionaryLookup();
        hat.Id = 18;
        hat.Name = "HAT";
        hat.AnimationClipParameter = "isHat";
        hat.Subject = false;
        hat.AudioClipNumber = 17;
        dictionaryLookups.Add(hat);

        var duck = new DictionaryLookup();
        duck.Id = 19;
        duck.Name = "DUCK";
        duck.AnimationClipParameter = "isDuck";
        duck.Subject = true;
        duck.AudioClipNumber = 18;
        dictionaryLookups.Add(duck);

        var apple = new DictionaryLookup();
        apple.Id = 20;
        apple.Name = "APPLE";
        apple.AnimationClipParameter = "isApple";
        apple.Subject = false;
        apple.AudioClipNumber = 19;
        dictionaryLookups.Add(apple);
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
        //char[] board2 = new char[8];
        //for (int i = 0; i < 8; i++)
        //{
        //    if (Row2[i].childCount > 0)
        //    {
        //        board2[i] = Row2[i].GetChild(0).gameObject.name[0];
        //    }
        //}

        // Row 3
        //char[] board3 = new char[8];
        //for (int i = 0; i < 8; i++)
        //{
        //    if (Row3[i].childCount > 0)
        //    {
        //        board3[i] = Row3[i].GetChild(0).gameObject.name[0];
        //    }
        //}     

        Search(board1, dictionaryLookups);
        // Search(board2, dictionaryLookupsList);
        //Search(board3, dictionaryLookupsList);

        // for this string in Current Words, use this
        for (int i = 0; i < currentWords.Count; i++)
        {
           // print(currentWords.Count);
            foreach (var lookup in dictionaryLookups)
            {
                // print(lookup.Name);
                if (currentWords.Count > 0)
                {
                    if (currentWords[i] == lookup.Name)
                    {
                        // if word is a noun, and another object is on the screen
                        if (lookup.Subject)
                        {
                            subjectScript.Animation(lookup.AnimationClipParameter);
                            soundManagerScript.playSound(soundManagerScript.wordSoundList[lookup.AudioClipNumber]);                            
                        }

                        // if word is a verb, or another word that does not require another object on the screen
                        else
                        {                         
                            fairyScript.Animation(lookup.AnimationClipParameter);
                           // soundManagerScript.playSound(soundManagerScript.wordSoundList[lookup.AudioClipNumber]);
                        }                        
                    }
                }
            }
            //  }

            //RULES ----------------         
            currentWords.Clear();
        }
    }


    private bool Search(char[] board, List<DictionaryLookup> dictionaryLookups)
    {
        for (int i = 0; i < board.Length; i++)
        {
            foreach (DictionaryLookup dictionaryLookup in dictionaryLookups)
            {
                //Debug.Log(dictionaryLookup);              
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

        //print(currentWords.Count);

        return found;
    }
}