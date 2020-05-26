using System.Collections.Generic;

namespace Firebase_a.Models
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class Brand
    {
        public string name { get; set; }
        public string website { get; set; }
    }

    public class ResponseResult
    {
        public Dictionary<string, User> users { get; set; }
        public Dictionary<string, Brand> brands { get; set; }
    }

}