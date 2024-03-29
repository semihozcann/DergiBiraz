﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Entities.DTOs.ArticleComments
{
    public class ArticleCommentComfirmationDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ArticleId { get; set; }
        public string Content { get; set; }
        public bool Assent { get; set; }
    }
}
