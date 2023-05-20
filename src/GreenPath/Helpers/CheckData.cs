using GreenPath.ViewModels;

class CheckData
{
    private string type;
    private DataViewModel data;

    public CheckData(string type, DataViewModel data)
    {
        this.type = type;
        this.data = data;
    }

    public string CheckFields()
    {
        List<string> fields = new List<string>();

        if(!isValid() && type == "candidato"){
            if(data.Name == null) fields.Add("Nome");
            if(data.Surname == null) fields.Add("Sobrenome");
            if(data.Profession == null) fields.Add("Profissão");
            if(data.Curriculum == null) fields.Add("Currículo");
        }
        else if(!isValid() && type == "empresa"){
            if(data.CompanyName == null) fields.Add("Razão Social");
            if(data.CNPJ == null) fields.Add("CNPJ");
            if(data.Area == null) fields.Add("Área");
            if(data.Certificates == null) fields.Add("Certificações");
        }

        return string.Join(", ", fields);
    }

    public bool isValid()
    {
        if (type == "candidato" && (data.Name == null || data.Surname == null || data.Profession == null || data.Curriculum == null)) return false;
        else if (type == "empresa" && (data.CompanyName == null || data.CNPJ == null || data.Area == null || data.Certificates == null)) return false;
        else return true;
    }
}