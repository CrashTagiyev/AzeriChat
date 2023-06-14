using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AzeriChat
{
    public class User
    {
        Guid id { get; set; } =Guid.NewGuid();
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? Birthday { get; set; }
        public Image UserImage { get; set; }

        public TextBox? UsersChat { get; set; }

       
    }
}
