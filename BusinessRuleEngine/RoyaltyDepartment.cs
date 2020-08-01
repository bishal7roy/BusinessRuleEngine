using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class RoyaltyDepartment
    {
        private bool _duplicateSlip = false;
        public bool Royalty(bool duplicateSlip)
        {
            _duplicateSlip = duplicateSlip;

            if (_duplicateSlip == true)
            {
                Console.WriteLine("Duplicate Slip Recieved by Royalty Department");
                return true;
            }
            return false;
        }
    }
}
