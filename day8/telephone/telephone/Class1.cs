using System;
public class Telephone
{
    protected string _phonetype;
        public string Phonetype
    {

        get
        {
            return _phonetype;
        }
        set
        {
            if (_phonetype != null) _phonetype = value;
        }
    }

    public void Ring()
    {
        Console.WriteLine("Ringing the {0}", _phonetype);
    }
    public Telephone()
    {

    }

    public Telephone(string phone)
    {
        _phonetype = phone;
    }
}
public class ElectronicPhone : Telephone
{
     _phonetype = "Digital";
}
