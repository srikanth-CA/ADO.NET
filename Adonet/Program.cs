using DataAccessLayer;
using System.Data;
using System.Runtime.CompilerServices;
using Models;
using Utilities;



namespace Adonet
{
    delegate  int validateId(int id);
    class A
    { 
       public int getid(int id) { Console.WriteLine("A--Instance--getid"); return 1; }

        public static int getidflag(int id) { Console.WriteLine("A--Static--getid"); return 0; }

        public void getidS(string id) { Console.WriteLine("A--Instance--getid string");  }

        public double getFunc(int id, string s, char c) { Console.WriteLine("getFunc"); return 1; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {


          //  string s = "test";
          //  int j=s.Length;

            
          //var s1=  s.AddString(" test1");


          //  Empployee e1 = new Empployee() { description = "Fourth Record", empid = 4, name = "Jessica" };

          //  var flag = e1.ValidateEmpid();





            DataAcess da = new DataAcess();
            DataSet ds = new DataSet();
            ds = da.Getdata();

            //var d = ds.Tables[0].AsEnumerable();



            //foreach (var e in d)
            //{


                


            //}


            //List<Empployee> emplist = new List<Empployee>()
            //{
            //    new Empployee(){ description="First Record", empid=1, name="John"},
            //    new Empployee(){description="Second Record", empid=2, name="Steve"},
            //    new Empployee(){description="Third Record", empid=3, name="Jay"},
            //};


            



            //var d1 = (from e in emplist where e.empid > 1 select e).ToList();

            



            
            //emplist.Add(e1);
           
            //foreach(Empployee e in  emplist)
            //{

            //   Console.WriteLine(e.description +" "+e.empid+" "+e.name);

            //}
            
            
            
            
            //List<order> orderlist = new List<order>()
            //{
            //  new order(){  OrderDesc="Sales Order 1", Orderid=100, Total="1000" },
            //  new order(){ OrderDesc="Sales Order 2", Orderid=101, Total="2000"},
            //  new order(){ OrderDesc="Sales Order 3", Orderid=102, Total="3000"}
            //};

           

            /*

            Empployee e;
            e = new Empployee() { empid = 7, description = "", name = "test" };

            //Declaring variable to Delegate
            validateId v;
           
            A a1=new A();


            //this is adding values to dlegate invocation list
            v = a1.getid;
            v += A.getidflag;
            Func<int, int> f1= a1.getid;

            Func<int, string, char, double> f2 = a1.getFunc;

            f2(0, "", 'v');
            Action<string> a111 = a1.getidS;


            //Anonymous method
            v += delegate (int i)
            {
                Console.WriteLine("Anonymouse Method");
                return 1;
            };

            //Lambda Expression   GOES TO
            v +=  (int i) =>
            {
                Console.WriteLine("Lambda Expression ");
                return 2;
            };

            // v += a1.getidS;

            //Invoking delegate
            Console.WriteLine(v(4));





            string s = "test";
          string str=  s.AddString(" Data");


            order od=new order();
            od.Orderid = 0;
            bool flag2 = od.ValidateOrderid();



            DataAcess da=new DataAcess();
            DataSet ds=new DataSet();
            ds=da.Getdata("uk");

            List<Empployee> emplist = new List<Empployee>()


            {

            new Empployee() { empid = 1 , description="Seattle", name="test"},new Empployee() {  empid=1, name="",   description="Seattle"     },
                new Empployee() { empid = 3 , description="Tacoma", name="test"},new Empployee() { empid = 4 , description="London", name="test"},
                new Empployee() { empid = 5 , description="London", name="test"},new Empployee() { empid = 6 , description="London", name="test"},




        };
            


            bool flag=new Helprs.Utils().ValidateEmpid(e.empid);

            bool flag1 = e.ValidateEmpid();


            emplist.Add(e);


            var a = from emp in emplist
                    select emp;

            var b = from emp in emplist
                    where emp.description == "London"
                    select emp;

            var c = emplist.Where(e => e.description == "London").Select(e =>new { id = e.empid, fullname = e.name } );





            foreach (var  emp in c)
            {
                Console.WriteLine(emp.id +" "+emp.fullname);


            }


            Console.WriteLine(emplist.Count);*/


            Console.Read();

          //  Console.WriteLine("Hello, World!");
        }
    }
}
