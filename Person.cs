using System; 
public class Person
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public int Age { get; set; }
//no parameters
  public Person() {}
  public Person(string firstname, string lastname) {
    FirstName = firstname;
    LastName = lastname;
  }

}