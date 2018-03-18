using System;

namespace KnockoutJS.Models
{
    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public class PersonViewModel
    {
        private const string DATE_FORMAT = "mm/dd/yyyy";

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; } = Gender.Male;

        public string LastUpdated { get; set; } = DateTime.Now.ToString(DATE_FORMAT);
    }
}
