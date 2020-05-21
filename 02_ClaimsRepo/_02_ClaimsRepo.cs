using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsRepo
{
    public class ClaimsRepo
    {
        public Queue<ClaimsClass> _claimsQueue = new Queue<ClaimsClass>();
        //Read
        public Queue<ClaimsClass> ShowAllClaims()
        {
            return _claimsQueue;
        }
        
        
        //Create
        public void EnterNewClaim(ClaimsClass newclaimsClass)
        {
            _claimsQueue.Enqueue(newclaimsClass);
        }

        //Delete helper
        public void DequeueClaim()
        {
            _claimsQueue.Dequeue();
        }
        //Peek Helper
        public ClaimsClass Peek()
        {
            ClaimsClass test = _claimsQueue.Peek();
            return test;

        }
    }
}



