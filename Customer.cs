using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Blake_EntityFramework
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public int BirthDate { get; set; }
        public int? CellPhoneNumber { get; set; }
        public int? HomePhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }

        //Normalization
        //1NF
        //Likes removed do to plurality, specific "likes" catagories were not listed so no new entity was made.
        //Cell and Home phone separated into two columns to give each column an atomic value.

        //2NF
        //attempted to make CustomerId the primary key
        //unsure how to make address work better. I tried moving it to a new table but i didn't know what to pair it up with other than customer id which is a primary key

        //I don't know how to remove null values in this case given they were allowed to be null, 
    }
}
