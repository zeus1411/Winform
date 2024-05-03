using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndEditForm1
{
    internal class StaticClass
    {
        public static int SetGlobalUserId { get; set; }
        public static void SetGlobalUserID(int userId)
        {
            SetGlobalUserId = userId;
        }

    }
}
