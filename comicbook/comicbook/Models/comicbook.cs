﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comicbook.Models
{
    public class comicbook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public Artist[] Artists { get; set; }
        public string DisplayText
        {
            get
            {
                return Title + " #" + IssueNumber;
            }
        }
        public string getCoverImageName
        {
            get
            {
                var a = Title.ToLower().Replace(" ", "-")+ "-" + IssueNumber +".jpg";
                return a;
            }
        }
    }
}