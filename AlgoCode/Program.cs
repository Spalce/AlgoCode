
int GetLengthOfLngestString(string input)
{
    var maxLegth = 0;
    var startIndex = 0;

    Dictionary<char, int> charIndex = new Dictionary<char, int>();

    for (int i = 0; i < input.Length; i++)
    {
        char current = input[i];
        if (charIndex.ContainsKey(current) && charIndex[current] >= startIndex)
        {
            startIndex = charIndex[current] + 1;
        }

        charIndex[current] = i;
        maxLegth = Math.Max(maxLegth, i - startIndex + 1);
    }

    return maxLegth;
}

Console.WriteLine(GetLengthOfLngestString("abrkaabcdefghijjxxx"));