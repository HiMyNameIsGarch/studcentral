﻿namespace studcentral.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
        public int FacultyId { get; set; }

    }
}
