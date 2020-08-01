using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    class Book : PhysicalProduct
    {
        public Book() : base()
        {
            RoyaltyDepartment royalty = new RoyaltyDepartment();
            royalty.Royalty(true);    //RoyaltyDepartment will be called to provide duplicate slip
        }
    }
}
