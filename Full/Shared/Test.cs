﻿namespace Full.Shared
{
    public class Test
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public string RightOption { get; set; }

        public Lesson Lesson { get; set; }
    }
}
