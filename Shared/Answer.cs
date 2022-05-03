﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_Prototype.Shared
{
    public class Answer
    {
        [Key]
        public Guid AnswerId { get; set; }
        public Guid StudentId { get; set; }
        public Guid ExamId { get; set; }
        public  string Text { get; set; }
    }
}
