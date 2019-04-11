using PracticeStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeStore.Validators
{
    public class SpamValidator : ValidationAttribute
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public int MaxAllowed { get; set; }

        public SpamValidator()
        {
            MaxAllowed = 1;

            ErrorMessage = "Found other posts with same content, are you sure this isn't spam?";
        }

        public SpamValidator(int number)
        {
            MaxAllowed = number;

            ErrorMessage = "Found other posts with same content, are you sure this isn't spam?";
        }

        public override bool IsValid(object value)
        {
            List<Post> postCheck = db.Posts.Where(p => p.Content == value.ToString()).ToList();

            if (postCheck.Count < MaxAllowed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}