using System;
using System.Collections.Generic;
public class Coordinates
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}
public class Dob
{
    public DateTime Date { get; set; }
    public int Age { get; set; }
}
public class Id
{
    public string Name { get; set; }
    public string Value { get; set; }
}
public class Info
{
    public string Seed { get; set; }
    public int Results { get; set; }
    public int Page { get; set; }
    public string Version { get; set; }
}
public class Location
{
    public Street Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Postcode { get; set; }
    public Coordinates coordinates { get; set; }
    public Timezone timezone { get; set; }
}
public class Login
{
    public string Uuid { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string Md5 { get; set; }
    public string Sha1 { get; set; }
    public string Sha256 { get; set; }
}
public class Name
{
    public string Title { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
}
public class Picture
{
    public string Large { get; set; }
    public string Medium { get; set; }
    public string Thumbnail { get; set; }
}
public class Registered
{
    public DateTime Date { get; set; }
    public int Age { get; set; }
}
public class Result
{
    public string Gender { get; set; }
    public Name Name { get; set; }
    public Location Location { get; set; }
    public string Email { get; set; }
    public Login Login { get; set; }
    public Dob Dob { get; set; }
    public Registered Registered { get; set; }
    public string Phone { get; set; }
    public string Cell { get; set; }
    public Id id { get; set; }
    public Picture picture { get; set; }
    public string Nat { get; set; }
}
public class PersonData
{
    public List<Result> results { get; set; }
    public Info info { get; set; }
}
public class Street
{
    public int number { get; set; }
    public string name { get; set; }
}
public class Timezone
{
    public string offset { get; set; }
    public string description { get; set; }
}

public struct SDetailsData
{
    public string ImgURl;
    public string Email;
    public string PersonName;
    public string Number;
    public string Gender;
    public string Age;
    public string City;
}