﻿namespace studcentral.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public Teacher Lecture { get; set; }
        public int LectureId { get; set; }
        public string Name { get; set; }
    }
}