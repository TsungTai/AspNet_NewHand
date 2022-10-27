using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
namespace WebApplication1.Models
{
    public class MemberInfoViewModel
    {
        public Member Member { get; set; }
        public List<Car> Cars { get; set; }
    }
}