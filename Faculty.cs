using System;
public class Faculty : Person {


public string ID {get; set;}
public string TITLE {get; set;}
public DateTime DATEOFEMPLOYEMENT {get; set;}
public string EMPLOYER {get; set;}
public double YEARLYSALARY {get; set;}
public bool TENURED {get; set;}

public Faculty(): base () {
  TITLE = "Instructor";
}

public Faculty(string firstname, string lastname) : base (firstname, lastname) {
  TITLE = "Instructor";
}

public bool GrantTenure() {
  DateTime thisDay = DateTime.Today;
  DateTime difference = thisDay - DATEOFEMPLOYEMENT;
  if (difference.Year >= 5) {
    TENURED = true;
    return true;
    
  }
  TENURED = false;
  return false;
}

public bool Promote() {
  DateTime thisDay = DateTime.Today;
  DateTime difference = thisDay - DATEOFEMPLOYEMENT;
  int experience = difference.Year;
  if (TITLE = "Instructor" && experience > 2){
    TITLE = "Assistant Professor";
    Console.WriteLine("Faculty promoted to Assistant Professor rank");
  }
  else if (TITLE = "Assistant Professor" && experience > 5){
    TITLE = "Associate Professor";
    Console.WriteLine("Faculty promoted to Associate Professor rank");
  }
  else if (TITLE = "Associate Professor" && experience > 10){
    Console.WriteLine("Faculty promoted to Professor rank");
  }
  else (TITLE = "Professor"){
    Console.WriteLine("No more promotion possible");
  }
}


}