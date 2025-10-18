using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopyApp.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        private string? LastName { get; set; }
        public Address? StudAddress { get; set; }

        public Student GetReference() => this;

        public Student GetShallowCopy() => (Student)MemberwiseClone();  // field-by-field copy

        public Student GetDeepCopy()
        {
            Student student = (Student)MemberwiseClone();
            student.StudAddress = new Address()
            {
                Street = StudAddress?.Street,
                Number = StudAddress?.Number,
                ZipCode = StudAddress?.ZipCode
            };

            return student;
        }

        public Student(Student student)
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            StudAddress = new Address()
            {
                Street = student.StudAddress?.Street,
                Number = student.StudAddress?.Number,
                ZipCode = student.StudAddress?.ZipCode
            };
        }
    }
}