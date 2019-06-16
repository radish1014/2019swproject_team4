using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking_System : MonoBehaviour
{

    private Dictionary<string, int> Ranking;

    private void awake()
    {
        Ranking = new Dictionary<string, int>();
        StartCoroutine(HighScore());
    }

    private IEnumerator HighScore()
    {
        string _score = "444444";
        string _name = "SAJANGNIM";
        string _hash_origin = _name + "_" + _score + "_hash";
        string _hash = Md5(_hash_origin);
        WWW webRequest = new WWW("http://localhost/InsertScore.php?name=" + _name + "&score=" + _score + "&hash=" + _hash);
        yield return webRequest;
        yield return StartCoroutine(recieveRank());
    }

    private IEnumerator recieveRank()
    {
        WWW webRequest = new WWW("http://localhost/LoadRanking.php");
        yield return webRequest;

        string[] stringSeparators = new string[] { "\n" };
        string[] lines = webRequest.text.Split(stringSeparators, System.StringSplitOptions.RemoveEmptyEntries);

        Ranking.Clear();
        for (int i = 0; i < lines.Length; i++)
        {
            string[] _parts = lines[i].Split(',');
            string _name = _parts[0];
            int _score = int.Parse(_parts[1]);
            Ranking.Add(_name, _score);
        }
    }

    public string Md5(string strToEncrypt)
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);

        // encrypt bytes
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        // Convert the encrypted bytes back to a string (base 16)
        string hashString = "";

        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }

        return hashString.PadLeft(32, '0');
    }
}
