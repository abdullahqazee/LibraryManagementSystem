using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class BookCopy
    {
        private int copyId { get; set; }
        public bool isAvailable { get; set; }
        private DateTime? DueDate { get; set; }
        private Member Member { get; set; }
        public void GetDetails()
        {
            Console.WriteLine($"Is it available? + {isAvailable}");
            Console.WriteLine($"Date + {DueDate}");
            Console.WriteLine($"Member + {Member.GetDetails}");
            Console.WriteLine();
        }

        public BookCopy(int Copy_Id, bool isAvailable)
        {
            this.copyId = Copy_Id;
            this.isAvailable = isAvailable;
        }

        public bool Issue(Member member)
        {
            if (isAvailable)
            {
                isAvailable = false;
                DueDate = DateTime.Today.AddDays(14);
                Member = member;
                return true;
            }
            return false;
        }

        public bool Return()
          {
                if (!isAvailable)
                {
                    isAvailable = true;
                    Member = null;
                    DueDate = null;
                    return true;
                }
                return false;
            }

            public bool ReIssue()
            {
                if (!isAvailable) {
                DueDate= DateTime.Today.AddDays(14);
                    return true;
                }
                return false;
            }


        //internal class BookCopy
        //{
        //    private int copyId { get; set; }
        //    private bool isAvailable { get; set; }
        //    private DateTime? DueDate { get; set; }
        //    private Member Member { get; set; }

        //    public void GetDetails()
        //    {
        //        Console.WriteLine($"Is it Available ?:  + {isAvailable}");
        //        Console.WriteLine($"Date is:  + {DueDate}");
        //        Console.WriteLine($"Member:  + {Member.GetDetails}");
        //        Console.WriteLine();
        //    }

        //    public BookCopy(int copyId, bool isAvailable)
        //    {
        //        this.copyId = copyId;
        //        this.isAvailable = isAvailable;
        //    }

        //    public bool Issue(Member member)
        //    {
        //        if (isAvailable)
        //        {
        //            isAvailable = false;
        //            DueDate = DateTime.Today.AddDays(14);
        //            Member = member;

        //        }
        //        return true;
        //    }

        //   

        //}
    }
}
