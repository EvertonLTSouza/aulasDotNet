public class Repeticao4
{
    public int populacaoA = 80000;
    public int populacaoB = 200000;
    public int ano = 0;
    private double taxaA = 3;
    private double taxaB = 1.5;
    public void proxAno ()
    {
        populacaoA = System.Convert.ToInt32(populacaoA * (1 + (taxaA/100)));
        populacaoB = System.Convert.ToInt32(populacaoB * (1 + (taxaB/100)));
        ano++;
    }
    public void setTaxaA (double a)
    {
        taxaA = a;
    }

    public void setTaxaB (double a)
    {
        taxaB = a;
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
    public bool CompTaxa()
    {
        if(taxaA > taxaB)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}