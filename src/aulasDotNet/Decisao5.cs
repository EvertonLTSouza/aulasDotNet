public class Decisao5
{
    public double nota1;
    public double nota2;
    private double media;
    public string Situacao()
    {
        media = (nota1 + nota2) / 2;
        if(media == 10){
            return "Aprovado com Distinção";
        }
        else if(media >= 7)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprovado";
        }
    }
}