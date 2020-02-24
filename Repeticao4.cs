public class Repeticao4
{
    public int populacaoA = 80000;
    public int populacaoB = 200000;
    public int ano = 0;
    public void proxAno ()
    {
        populacaoA = System.Convert.ToInt32(populacaoA * 1.03);
        populacaoB = System.Convert.ToInt32(populacaoB * 1.015);
        ano++;
    }
    public bool Maior ()
    {
        if (populacaoA >= populacaoB)
        {
            return true;
        }
        {
            return false;
        }
    }
}