namespace delegates
{
    #region delegate
    //public delegate void hellofunctiondelegate(string message);
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        hellofunctiondelegate del = new hellofunctiondelegate(hello);
    //        del("hello from delegate");
    //        // a delegate is a type safe fuction pointer
    //    }
    //    public static void hello(string strmessage) 
    //    {
    //        Console.WriteLine(strmessage);
    //    }
    //}
    #endregion
    #region delegate in use
    class program
    {
        static void Main(string[] args)
        {
            List<employee> emplist = new List<employee>();
            emplist.Add(new employee() { ID = 101, NAME = "mary", SALATY = 5000, EXPERINCE = 5 });
            emplist.Add(new employee() { ID = 101, NAME = "mike", SALATY = 4000, EXPERINCE = 4 });
            emplist.Add(new employee() { ID = 101, NAME = "john", SALATY = 6000, EXPERINCE = 6 });
            emplist.Add(new employee() { ID = 101, NAME = "todd", SALATY = 3000, EXPERINCE = 3 });

            IsPromotetable isPromotetable = new IsPromotetable(Promote);

            employee.PromoteEmployee(emplist, isPromotetable);



        }

        public static bool Promote(employee emp)
        {
            if (emp.EXPERINCE >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool IsPromotetable(employee empl);

    class employee
    {

        public int ID { get; set; }
        public string? NAME { get; set; }
        public int SALATY { get; set; }
        public int EXPERINCE { get; set; }



        public static void PromoteEmployee(List<employee> employeeslist,IsPromotetable IsEligiblrToPromote)
        {
            foreach (employee employee in employeeslist)
            {
                // delegated IsPromotetable
                if (IsEligiblrToPromote(employee))
                {
                    Console.WriteLine(employee.NAME + " promoted");
                }
                //hard coded employeeslist
                if (employee.EXPERINCE >= 5)
                {
                    Console.WriteLine(employee.NAME + "promoted");
                }
            }
        }
    }
    #endregion
}