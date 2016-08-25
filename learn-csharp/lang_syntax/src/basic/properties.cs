
class Person {

    /** Full Property. */
    private string name;
    public string Name {
        get { return name; }
        set { name = value; }
    }

    /** Automatic. */
    public string Email {get; set;}


    /** ReadOnly */
    public string SocialSecurity {get;}


    /** ReadOnly and Initialized. */
    public string Gender {get;} = "M";
    
}