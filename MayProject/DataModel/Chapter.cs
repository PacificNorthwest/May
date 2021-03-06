﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayProject.Contracts;

namespace MayProject.DataModel
{
    [Serializable]
    public class Chapter : IPlainTextElement
    {
        public string Title { get; set; }
        public string Annotation { get; set; }
        public string Text { get; set; }

        public Chapter(string title)
        {
            Title = title;
        }

        public Chapter() : this("No title")
        { }
    }
}
