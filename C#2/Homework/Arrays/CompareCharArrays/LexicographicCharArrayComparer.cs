public static class My_LexicographicCharArrayComparer
{
    public static int Compare(string arrayOne, string arrayTwo)
    {
        
        int first = 1;
        int second = -1;
        int comparer = (arrayOne.Length < arrayTwo.Length) ? first : second ;
        int comparableLenght = (arrayOne.Length < arrayTwo.Length) ? (arrayOne.Length) : (arrayTwo.Length);
        arrayOne.ToLower();
        arrayTwo.ToLower();

        for (int i = 0; i < comparableLenght; i++)
        {
            if (arrayOne[i] > arrayTwo[i])
            {
                comparer++;
                break;
            }
            else if (arrayOne[i] < arrayTwo[i])
            {
                comparer--;
                break;
            }
        }

        return comparer;
    }
}
