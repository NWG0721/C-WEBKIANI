public class Person
{

    public Person(int age):this(age,"Ali","Akbari")
    {
        //this.Age = age;
    }
    public Person(int age,string firstName):this(age,firstName,"Akabri")
    {
        //this.Age = age;
        //this.FirstName = firstName;
    }
     public Person(int age,string firstName,string lastName)
    {
        this.Age = age;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    //PROPERTY 
    private int age;
    //private int x;

   public int Age
   {
        get
        {
        return this.age;
        }
        set
        {
            if(value <=0)
                this.age = 10;
            else
                this.age = value;
        }

   }

    public string FirstName { get; set; }
    public string LastName { get; set;}

    public string FullName
    {
        get
        {
            return this.Age +","+ this.FirstName + "," + this.LastName;
        }
    }
   

    // public int GetAge()
    // {
    //     return this.age;
    // }
    // public void SetAge(int age)
    // {
    //     if(age <=0)
    //          this.age = 10;
    //     else
    //         this.age = age;
    // }
}