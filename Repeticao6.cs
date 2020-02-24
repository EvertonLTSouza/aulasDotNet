using System;
public class Repeticao6
{
    private int num = 1;

    public void setNum(int a)
    {
        num = a;
    }
    public void printNextLine()
    {
        Console.WriteLine(num);
        num++;
    }

    public void printNextNum()
    {
        Console.Write(num + " ");
        num++;
    }
}