
var cekic = new Cekic();    
var civi = new Civi();
var builder = new Builder(cekic,civi);

builder.BuildHouse();

public class Cekic   // dependecy
{
    public void Use()
    {
        Console.WriteLine("Çekiç kullanıldı.");
    }
}
public class Civi
{
    public void Use()
    {
        Console.WriteLine("Çivi kullanıldı.");
    }
}
public class Builder
{
    Cekic _cekic;
    Civi _civi;
    public Builder(Cekic cekic,Civi civi)
    {
      _cekic = cekic;
      _civi = civi;
    }

    public void BuildHouse()
    {
        var cekic = new Cekic();
        cekic.Use();
        var civi = new Civi();
        civi.Use();
        Console.WriteLine("Ev inşa edildi.");
    }
}
