using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace E4mini_Admin_tool
{
    internal class Functions
    {
          Form1 form1 = new Form1();
        public  void Message(string content)
        {
            
               form1.textBox1.Text = content.ToString();
            
        }
    }
}
