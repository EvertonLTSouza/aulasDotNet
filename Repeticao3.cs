public class Repeticao3
{
    public bool ValidaNome(string nome)
    {
        if(nome.Length < 3)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool ValidaIdade (int idade)
    {
        if (idade > -1 && idade < 151)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ValidaSalario(int salario)
    {
        if (salario > 0 )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ValidaSexo(char sexo)
    {
        if(char.ToLower(sexo) == 'f' 
        || char.ToLower(sexo) == 'm')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ValidaEstadoCivil(char estadocivil)
    {
        switch(char.ToLower(estadocivil))
        {
            case 's':

            case 'c':

            case 'v':

            case 'd':
                return true;    
                break;
            default:
                return false;
                break;
            
        }
    }
}