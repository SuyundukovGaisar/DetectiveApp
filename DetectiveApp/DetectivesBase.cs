using System;
using System.Collections.Generic;

namespace DetectiveApp
{
    [Serializable]
    public class DetectivesBase
    {
        public List<Detective> Detectives { get; set; }
        public List<Suspect> Suspects { get; set; }
        public List<Case> Cases { get; set; }
        public DetectivesBase() { }
        public DetectivesBase(List<Detective> detectives, List<Suspect> suspects, List<Case> cases)
        {
            Detectives = detectives;
            Suspects = suspects;
            Cases = cases;
        }
    }
    [Serializable]
    public class Detective
    {
        public string Name { get; set; }
        public string Direction { get; set; }
        public List<string> Occupation { get; set; }
        public int Age { get; set; }
        public PlaceOfBirth PlaceOfBirth { get; set; }
        public int CasesSolved { get; set; }
        public Detective() { }
        public Detective(string name, string direction, List<string> occupation, int age, PlaceOfBirth placeOfBirth, int cases)
        {
            Name = name;
            Direction = direction;
            Occupation = occupation;
            Age = age;
            PlaceOfBirth = placeOfBirth;
            CasesSolved = cases;
        }
    }
    [Serializable]
    public class PlaceOfBirth
    {
        public string Country { get; set; }
        public string City { get; set; }
        public PlaceOfBirth() { }
        public PlaceOfBirth(string city, string country)
        {
            City = city;
            Country = country;
        }
    }
    [Serializable]
    public class Suspect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public Violation Violation { get; set; }
        public Suspect() { }
        public Suspect(int id, string name, int age, Address address, Violation violation)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
            Violation = violation;
        }
    }
    [Serializable]
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public Address() { }
        public Address(string country, string city)
        {
            Country = country;
            City = city;
        }
    }
    [Serializable]
    public class Violation
    {
        public string Accusation { get; set; }
        public string Punishment { get; set; }
        public Violation() { }
        public Violation(string accusation, string punishment)
        {
            Accusation = accusation;
            Punishment = punishment;
        }
    }
    [Serializable]
    public class Case
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Employee Employee { get; set; }
        public Offender Offender { get; set; }
        public string Punishment {  get; set; }
        public Case() { }
        public Case(int id, string title, Employee employee, Offender offender, string punishment)
        {
            Id = id;
            Title = title;
            Employee = employee;
            Offender = offender;
            Punishment = punishment;
        }
    }
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public Employee() { }
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
    [Serializable]
    public class Offender
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Offender() { }
        public Offender(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
