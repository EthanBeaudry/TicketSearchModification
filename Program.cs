using System;
using System.IO;
using System.Linq; 
using System.Collections.Generic;
namespace TicketingSystemSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ticket Search System!");
            string Bugfile = "Tickets.csv";
            string EnchancementFile ="Enchancements.csv";
            string TaskFile = "Task.csv";
           
                    
                    string choice;
                    do
                    {
                       
                        Console.WriteLine("1) Create a Ticket");
                        Console.WriteLine("2) Search for Ticket");
                        Console.WriteLine("3) Read Tickets");
                        Console.WriteLine("(Select an option from the menu)");
                        
                        choice = Console.ReadLine();
                        if (choice == "1") 

                        {
                        Console.WriteLine("Choose the ticket type:");
                        Console.WriteLine("1. Bug/Defect");
                        Console.WriteLine("2. Enhancement");
                        Console.WriteLine("3. Task");
                        
                            string TicketType = Console.ReadLine();
                            if (TicketType == "1")
                            {
                            Bug ticket = new Bug();
                            ticket.AskUser();
                            ticket.AddTickettoFile(Bugfile);
                            }

                            if (TicketType == "2")
                            {
                            Enhancement newenhancement = new Enhancement();
                            newenhancement.AskUser();
                            newenhancement.AddTickettoFile(EnchancementFile);
                        
                            }
                        
                            if (TicketType == "3")
                            {
                            Task newtask = new Task ();
                            newtask.AskUser();
                            newtask.AddTickettoFile(TaskFile);
                            }
                        }
                       
                     else if (choice == "2")
                      {
                          Console.WriteLine("Search According to:");
                          Console.WriteLine("1) Status");
                          Console.WriteLine("2) Priority");
                          Console.WriteLine("3) Submitter");
                          Console.WriteLine("(Please Select a number from the menu)");
                          String searchtype = Console.ReadLine();
                            BugFile ticketfile = new BugFile();
                            EnchancementFile newEnhancementFile = new EnchancementFile();
                            TaskFile newtaskfile = new TaskFile();
                            ticketfile.FileRead(Bugfile);
                            newEnhancementFile.FileRead(EnchancementFile);
                            newtaskfile.FileRead(TaskFile);
                             if (searchtype =="1")  
                             {
                             Console.WriteLine("Enter the Status: ");
                             string search = Console.ReadLine().ToLower();
                             var bugfilesearch =  ticketfile.Tickets.Where(m => m.status.ToLower().Contains((search)));
                             var enhancementfilesearch = newEnhancementFile.Tickets.Where(m => m.status.ToLower().Contains((search)));
                             var taskfilesearch = newtaskfile.Tickets.Where(m => m.status.ToLower().Contains((search)));
                            var Statuslist = bugfilesearch.Concat(enhancementfilesearch).Concat(taskfilesearch);
                                 Console.WriteLine($"There are {Statuslist.Count()} tickets with \"{search}\" as the Status:");
                                    foreach(Ticket t in Statuslist)
                                     {
                                        Console.WriteLine(t.Display());
                                     }  
                             }   
                             else if (searchtype == "2")
                             {
                                 Console.WriteLine("Enter the Priority:");
                                    string search = Console.ReadLine().ToLower();
                                    var bugfilesearch =  ticketfile.Tickets.Where(m => m.priority.ToLower().Contains((search)));
                                    var enhancementfilesearch = newEnhancementFile.Tickets.Where(m => m.priority.ToLower().Contains((search)));
                                    var taskfilesearch = newtaskfile.Tickets.Where(m => m.priority.ToLower().Contains((search)));
                                    var Statuslist = bugfilesearch.Concat(enhancementfilesearch).Concat(taskfilesearch);
                                    Console.WriteLine($"There are {Statuslist.Count()} tickets with \"{search}\" as the Priority:");
                                    foreach(Ticket t in Statuslist)
                                     {
                                        Console.WriteLine(t.Display());
                                     }  
                             }  
                             else if (searchtype == "3") 
                             {
                                 Console.WriteLine("Enter the Submitter: ");
                                    string search = Console.ReadLine().ToLower();
                                    var bugfilesearch =  ticketfile.Tickets.Where(m => m.submitter.ToLower().Contains((search)));
                                    var enhancementfilesearch = newEnhancementFile.Tickets.Where(m => m.submitter.ToLower().Contains((search)));
                                    var taskfilesearch = newtaskfile.Tickets.Where(m => m.submitter.ToLower().Contains((search)));
                                    var Statuslist = bugfilesearch.Concat(enhancementfilesearch).Concat(taskfilesearch);
                                    Console.WriteLine($"There are {Statuslist.Count()} tickets with \"{search}\" as the Submitter:");
                                    foreach(Ticket t in Statuslist)
                                     {
                                        Console.WriteLine(t.Display());
                                     }  
                             }  
                             else {break;}
                        }
                        else if (choice == "3")
                        {
                            Console.WriteLine("1) Display Bug Tickets");
                            Console.WriteLine("2) Display Enchancement Tickets");
                            Console.WriteLine("3) Display Task Tickets");
                            string TicketType = Console.ReadLine();
                            BugFile ticketfile = new BugFile();
                            EnchancementFile newEnhancementFile = new EnchancementFile();
                            TaskFile newtaskfile = new TaskFile();

                            ticketfile.FileRead(Bugfile);
                            newEnhancementFile.FileRead(EnchancementFile);
                            newtaskfile.FileRead(TaskFile);
                            if (TicketType == "1")
                            {
                                  
                                foreach(Ticket t in ticketfile.Tickets )
                                {
                                    Console.WriteLine(t.Display());
                                 }
                            }
                            else if (TicketType == "2")
                            {
                                foreach(Ticket t in newEnhancementFile.Tickets)
                                {
                                    Console.WriteLine(t.Display());
                                }
                            }
                            else if (TicketType == "3")
                            {
                                foreach(Ticket t in newtaskfile.Tickets)
                                {
                                    Console.WriteLine(t.Display());
                                }
                            }
                         }               

                    }while (choice == "1"|| choice == "2"|| choice == "3");
        } 

                        
                        
    } 

                   
    
            
}