using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManage.Model
{
    public class DangNhapModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password{ get; set; }
        public bool Status{ get; set; }
    }
}
