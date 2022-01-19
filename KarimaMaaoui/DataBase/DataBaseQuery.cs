using System;
using System.Collections.Generic;
using System.Text;

namespace KarimaMaaoui.DataBase
{
    public class DataBaseQuery
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
