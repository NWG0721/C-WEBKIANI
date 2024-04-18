public class Person
{
    //Field => camelCase _
    //Fileds=>Default Value
    // Value Type= > Default =0
    //Refernce Type=> Default =null
    private string id;
    public string FirstName{get;set;}
    public string LastName{get;set;}
    

   

    /*
    public string GetId()
    {
        return id;
    }
    */

    public string Id
    {
        get
        {
            return id;
        }
        set
        {
            //
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Invalid id value");
            if (value.Length != 10)
                throw new Exception("Invalid id length");
            bool isValid = true;
            foreach (var c in value)
            {
                if (!char.IsNumber(c))
                {
                    isValid = false;
                    break;
                }
            }
            if (!isValid)
                throw new Exception("Id must be numeric value");
            this.id = value;
        }
    }
    /*
    public void SetId(string id)
    {
        //
        if (string.IsNullOrWhiteSpace(id))
            throw new Exception("Invalid id value");
        if (id.Length != 10)
            throw new Exception("Invalid id length");
        bool isValid = true;
        foreach (var c in id)
        {
            if (!char.IsNumber(c))
            {
                isValid = false;
                break;
            }
        }
        if (!isValid)
            throw new Exception("Id must be numeric value");
        this.id = id;
    }
    */
    public string GetFullName()
    {
        // using 'this' for class member
        return this.FirstName + "," + LastName;
    }




}