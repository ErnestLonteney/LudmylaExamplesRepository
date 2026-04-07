using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesRevision
{
    abstract class Person
    {
        // State

        //private string firstName;
        //public string FirstName
        //{
        ////    public string GetFirstName()
        ////{
        ////    return firstName;
        ////}
        //get 
        //{
        //    return firstName;   
        //}
        //public void SetFirstName(string value)
        //{
        //    firstName = value;
        //}
        // set
        // {   
        //     firstName = value;
        // }
        //}       

        public int Id { get; set; }

        // private string firstName;
        public string FirstName
        {
            get
            {
                return field;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    field = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return field;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    field = value;
                }
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string DateOfBirth { get; }

        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        // Behavior

        public string GetInformation()
        {
            return $"Name: {FullName}, Date of Birth: {DateOfBirth}, Phone Number: {PhoneNumber}";
        }

        public virtual void GetMail(string message)
        {
            Console.WriteLine(message);
        }

        // Constructors

        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
