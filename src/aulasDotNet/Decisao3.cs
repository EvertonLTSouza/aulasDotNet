public class Decisao3
{
    public string Sexo (char a)
    {
        if(char.ToLower(a) == 'f')
        {
            return "Feminino";
        }
        else if(char.ToLower(a) == 'm')
        {
            return "Masculino";
        }
        else
        {
            return "Invalido";
        }
    }
}