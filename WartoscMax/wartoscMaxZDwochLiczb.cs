class wartoscMaxZDwochLiczb
{
    private int liczba1;
    private int liczba2;
    private int max;
    private bool aIsBigger;

    public wartoscMaxZDwochLiczb(int a, int b)
    {
        liczba1 = a;
        liczba2 = b;
    }

    public int wartoscMax()
    {
        if (liczba1 > liczba2)
            aIsBigger = true;
        else 
            aIsBigger = false;
        max = aIsBigger ? liczba1 : liczba2;
        return max;
    }
}
