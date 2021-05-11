using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TicketingSystemSearch
{
    public abstract class TicketFile
    {
        
        public string filePath { get; set; }
        public List<Ticket> Tickets { get; set; }

        public virtual void FileRead (string ticketfilepath)
        {
            filePath = ticketfilepath;
            Tickets = new List<Ticket>();

             
            
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    // create instance of Movie class
                    Ticket ticket = new Bug();
                    string line = sr.ReadLine();

                    string[] ticketDetails = line.Split(',');
                        ticket.ticketID = ticketDetails[0];
                        ticket.summary = ticketDetails[1];
                        ticket.status = ticketDetails[2];
                        ticket.priority = ticketDetails[3];
                        ticket.submitter = ticketDetails[4];
                        ticket.assigned = ticketDetails[5];
                        ticket.watching = ticketDetails[6].Split('|').ToArray();
                        
                        Tickets.Add(ticket);

                }
                sr.Close();
            }  
        } 
             
    public class BugFile : TicketFile
    {
            public override void FileRead (string ticketfilepath)
        {
            filePath = ticketfilepath;
            Tickets = new List<Ticket>();

             
            
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    // create instance of Movie class
                    Bug ticket = new Bug();
                    string line = sr.ReadLine();

                    string[] ticketDetails = line.Split(',');
                        ticket.ticketID = ticketDetails[0];
                        ticket.summary = ticketDetails[1];
                        ticket.status = ticketDetails[2];
                        ticket.priority = ticketDetails[3];
                        ticket.submitter = ticketDetails[4];
                        ticket.assigned = ticketDetails[5];
                        ticket.watching = ticketDetails[6].Split('|').ToArray();
                        ticket.Severity = ticketDetails[7];

                        
                        Tickets.Add(ticket);

                }
                sr.Close();
            }  
    }

    public class EnchancementFile : TicketFile
    {
        public override void FileRead (string ticketfilepath)
        {
            filePath = ticketfilepath;
            Tickets = new List<Ticket>();

             
            
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    // create instance of Movie class
                    Enhancement ticket = new Enhancement();
                    string line = sr.ReadLine();

                    string[] ticketDetails = line.Split(',');
                        ticket.ticketID = ticketDetails[0];
                        ticket.summary = ticketDetails[1];
                        ticket.status = ticketDetails[2];
                        ticket.priority = ticketDetails[3];
                        ticket.submitter = ticketDetails[4];
                        ticket.assigned = ticketDetails[5];
                        ticket.watching = ticketDetails[6].Split('|').ToArray();
                        ticket.Software = ticketDetails[7];
                        ticket.Cost = ticketDetails[8];
                        ticket.Reason = ticketDetails [9];
                        ticket.Estimate = ticketDetails [10];

                        
                        Tickets.Add(ticket);

                }
                sr.Close();
            }  
    }

    public class TaskFile : TicketFile
    {
        public override void FileRead (string ticketfilepath)
        {
            filePath = ticketfilepath;
            Tickets = new List<Ticket>();

             
            
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    // create instance of Movie class
                    Task ticket = new Task();
                    string line = sr.ReadLine();

                    string[] ticketDetails = line.Split(',');
                        ticket.ticketID = ticketDetails[0];
                        ticket.summary = ticketDetails[1];
                        ticket.status = ticketDetails[2];
                        ticket.priority = ticketDetails[3];
                        ticket.submitter = ticketDetails[4];
                        ticket.assigned = ticketDetails[5];
                        ticket.watching = ticketDetails[6].Split('|').ToArray();
                        ticket.ProjectName = ticketDetails[7];
                        ticket.DueDate = ticketDetails [8];

                        
                        Tickets.Add(ticket);

                }
                sr.Close();
            }  
    }
}  