string[] theWords = new string[3] { "valid", "this", "id" };
string testWord = "validThisIdValidThisId";
string testWord2 = "iDvalidtHis";
Console.WriteLine(IsCorrect(theWords, testWord));
Console.WriteLine(IsCorrect(theWords, testWord2));


bool IsCorrect(string[] words, string wordTest)
{
    bool isCorrect = true;
    string thisWord = "";

    for (int i = 0; i < wordTest.Length; i++)
    {
        if (!char.IsUpper(wordTest[i]) || i == 0)
        {
            thisWord = thisWord + wordTest[i];
        }
        else
        {
            if (!theWords.Contains(thisWord.ToLower()))
            {
                isCorrect = false;
                break;
            }
            else
            {
                thisWord = "";
                thisWord = thisWord + wordTest[i];
            }
        }
    }

    return isCorrect;
}