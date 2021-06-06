using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface ICoffee
    {
        
        string Name 
        { 
            set; 
            get; 
        }

        int Price 
        { 
            set; 
            get; 
        }
    }
}
