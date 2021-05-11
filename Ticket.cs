using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicketingSystemSearch
{
   public abstract class Ticket
    {
        public string ticketID {get; set;}
        public string summary {get; set;}
        public string status {get; set;}
        public string priority {get; set;}
        public string submitter {get; set;}
        public string assigned {get; set;}
        public int amountwatching {get; set;}
        public string[] watching {get; set;}

        public virtual void AskUser () 
        
            
            {
                        Console.WriteLine("Ticket ID: ");
                        ticketID = Console.ReadLine();

                        Console.WriteLine("Ticket Summary: ");
                        summary = Console.ReadLine();

                        Console.WriteLine("Ticket Status: ");
                        status = Console.ReadLine();

                        Console.WriteLine("Priority: ");
                        priority = Console.ReadLine();

                        Console.WriteLine("Submitter: ");
                        submitter = Console.ReadLine();

                        Console.WriteLine("Assignee: ");
                        assigned = Console.ReadLine();

                        Console.WriteLine("How Many Watchers?");
                        amountwatching = Convert.ToInt32(Console.ReadLine());

                        watching = new string[amountwatching];
                        for (int q = 0; q < amountwatching; q++)
                        {
                            Console.WriteLine("Watcher Name: ");
                            watching[q] = Console.ReadLine();
                       }          
            }
        
         public virtual void AddTickettoFile (string file)   

         {
             StreamWriter sw = new StreamWriter(file, true);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)}");
                        
                         sw.Close();
         }
   
        public virtual string Display ()
        {
            return $"Id: {ticketID}\nSummary: {summary}\nStatus: {status}\nPriority: {priority}\nSubmitter: {submitter}\nAssigned: {assigned}\nWatching: {string.Join(", ", watching)}\n";
        }
    }
public class Bug : Ticket
{
 public string Severity {get; set;}

 public override void AskUser ()
{
                        Console.WriteLine("Ticket ID: ");
                        ticketID = Console.ReadLine();

                        Console.WriteLine("Ticket Summary: ");
                        summary = Console.ReadLine();

                        Console.WriteLine("Ticket Status: ");
                        status = Console.ReadLine();

                        Console.WriteLine("Priority: ");
                        priority = Console.ReadLine();

                        Console.WriteLine("Submitter: ");
                        submitter = Console.ReadLine();

                        Console.WriteLine("Assignee: ");
                        assigned = Console.ReadLine();

                        Console.WriteLine("How Many Watchers?");
                        amountwatching = Convert.ToInt32(Console.ReadLine());

                        watching = new string[amountwatching];
                        for (int j = 0; j < amountwatching; j++)
                        {
                            Console.WriteLine("Watcher Name: ");
                            watching[j] = Console.ReadLine();
                       }    
                       Console.WriteLine("Severity: ");
                       Severity = Console.ReadLine();      
}
   public override void AddTickettoFile (string file)   
         {
             StreamWriter sw = new StreamWriter(file, true);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)},{Severity}");
                        
                         sw.Close();
         }
        public override string Display()
        {
            return $"Id: {ticketID}\nSummary: {summary}\nStatus: {status}\nPriority: {priority}\nSubmitter: {submitter}\nAssigned: {assigned}\nWatching: {string.Join(", ", watching)}\nSeverity: {Severity}\n";
        }
    
}

public class Enhancement : Ticket
{
    public string Software {get; set;}
    public string Cost {get; set;}
    public string Reason {get; set;}
    public string Estimate{get;set;}

        public override void AskUser()
        {
                        Console.WriteLine("Ticket ID: ");
                        ticketID = Console.ReadLine();

                        Console.WriteLine("Ticket Summary: ");
                        summary = Console.ReadLine();

                        Console.WriteLine("Ticket Status: ");
                        status = Console.ReadLine();

                        Console.WriteLine("Priority: ");
                        priority = Console.ReadLine();

                        Console.WriteLine("Submitter: ");
                        submitter = Console.ReadLine();

                        Console.WriteLine("Assignee: ");
                        assigned = Console.ReadLine();

                        Console.WriteLine("How Many Watchers?");
                        amountwatching = Convert.ToInt32(Console.ReadLine());

                        watching = new string[amountwatching];
                        for (int q = 0; q < amountwatching; q++)
                        {
                            Console.WriteLine("Watcher Name: ");
                            watching[q] = Console.ReadLine();
                       } 
                       Console.WriteLine("Software: ");
                       Software = Console.ReadLine();

                       Console.WriteLine ("Cost: ");
                       Cost = Console.ReadLine();

                       Console.WriteLine("Reason: ");
                       Reason = Console.ReadLine ();

                       Console.WriteLine("Estimate");
                       Estimate = Console.ReadLine();

        }
        public override void AddTickettoFile (string file)   
         {
             StreamWriter sw = new StreamWriter(file, true);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)},{Software},{Cost},{Reason},{Estimate}");
                        
                         sw.Close();
         }
        public override string Display()
        {
            return $"Id: {ticketID}\nSummary: {summary}\nStatus: {status}\nPriority: {priority}\nSubmitter: {submitter}\nAssigned: {assigned}\nWatching: {string.Join(", ", watching)}\nSoftware: {Software}\nCost: {Cost}\nReason: {Reason}\nEstimate: {Estimate}\n";
        }
 
}   
    public class Task : Ticket
    {
        public string ProjectName {get; set;}
        public string DueDate {get; set;}

         public override void AskUser ()
            {
                        Console.WriteLine("Ticket ID: ");
                        ticketID = Console.ReadLine();

                        Console.WriteLine("Ticket Summary: ");
                        summary = Console.ReadLine();

                        Console.WriteLine("Ticket Status: ");
                        status = Console.ReadLine();

                        Console.WriteLine("Priority: ");
                        priority = Console.ReadLine();

                        Console.WriteLine("Submitter: ");
                        submitter = Console.ReadLine();

                        Console.WriteLine("Assignee: ");
                        assigned = Console.ReadLine();

                        Console.WriteLine("How Many Watchers?");
                        amountwatching = Convert.ToInt32(Console.ReadLine());

                        watching = new string[amountwatching];
                        for (int q = 0; q < amountwatching; q++)
                        {
                            Console.WriteLine("Watcher Name: ");
                            watching[q] = Console.ReadLine();
                       }   
                       Console.WriteLine ("Project Name: ");
                       ProjectName = Console.ReadLine();

                       Console.WriteLine("Enter a due date (MM/DD/YY): ");
                       DueDate = Console.ReadLine();

             }
       public override void AddTickettoFile (string file)   
         {
             StreamWriter sw = new StreamWriter(file, true);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)},{ProjectName},{DueDate}");
             sw.Close();
         }
       public override string Display()
        {
            return $"Id: {ticketID}\nSummary: {summary}\nStatus: {status}\nPriority: {priority}\nSubmitter: {submitter}\nAssigned: {assigned}\nWatching: {string.Join(", ", watching)}\nProject Name: {ProjectName}\nDue Date: {DueDate}\n";
        }
    }    
}    