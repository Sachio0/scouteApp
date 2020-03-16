using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _2ndTry
{
    public class Page
    {
        [Key]
        int Id { get; set; }
        string Values { get; set; }
    }
}
