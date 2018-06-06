using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class team
    {
        String name;
        
        public team()
        {

        }

        public team(String n)
        {
            name = n;
        }

        public void setName(String n)
        {
            name = n;
        }

        public String getName()
        {
            return name;
        }
    }
    class person
    {
        team t;
        String firstName, lastName;
        public person()
        {
            t = new team();
        }
        public person(String tName, String fn, String ln)
        {
            t = new team();
            t.setName(tName);
            firstName = fn;
            lastName = ln;
        }
        public void setName(String tName, String fn, String ln)
        {
            t.setName(tName);
            firstName = fn;
            lastName = ln;
        }

        public String getTeamName()
        {
            return t.getName();
        }
        public String getName()
        {
            return firstName + " " + lastName;
        }
    }
    class manager : person
    {
        String carType;
        public manager()
        {
            
        }
        public manager(String tName, String fn, String ln, String ct): base(tName, fn, ln)
        {
            carType = ct;
        }
        public String getTeam()
        {
            return base.getTeamName();
        }
        public String getData()
        {
            return getName();
        }
    }
    class worker : person
    {
        String job;
        public worker()
        {
            
        }
        public void setName(String tName, String fn, String ln, String j)
        {
            base.setName(tName, fn, ln);
            job = j;
        }
        public String getTeam()
        {
            return base.getTeamName();
        }
        public String getData()
        {
            return base.getName() + ", "+job;
        }

        /*public String getName()
        {
            return base.getName() + ", " + job + "!!!!";
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            team[] ta = new team[2];
            manager[] ma = new manager[2];
            worker[] wa = new worker[4];

            for (int i = 0; i < 2; i++)
            {
                ta[i] = new team();
            }
            ta[0].setName("team3");
            ta[1].setName("team2");
            ma[0] = new manager("team1", "Dani", "Cohen","Audi");
            ma[1] = new manager("team2", "Dina", "Levi","Renault");
            for (int i = 0; i < 4; i++)
            {
                wa[i] = new worker();
            }
            wa[0].setName("team1", "ari", "Cohen", "Programmer");
            wa[1].setName("team1", "Yevgeny", "Cohen", "Programmer");
            wa[2].setName("team2", "Nino", "Cohen", "Programmer");
            wa[3].setName("team2", "Ori", "Cohen", "Programmer");

            Console.WriteLine("Please enter a name of a team");
            String tt = Console.ReadLine();
            Boolean found = false;
            for (int i = 0; i < 2; i++)
            {
                if (tt.Equals(ta[i].getName())){
                    found = true;
                }
            }
            if (found)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (tt.Equals(ma[i].getTeam()))
                    {
                        Console.WriteLine(ma[i].getData());
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (tt.Equals(wa[i].getTeam()))
                    {
                        Console.WriteLine(wa[i].getName());
                    }
                }
            }
            else
            {
                Console.WriteLine("Team not found");
            }
            Console.ReadLine();

        }
    }
}
