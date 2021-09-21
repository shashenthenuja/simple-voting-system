using System;
class smsSystem
{
    static void Main(string [] args)
    {
        bool stop_chk;
        int tgf=0,twl=0,hrp=0;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(">>>>>...::: WELCOME TO THE RT TELEDRAMA AWARDING FESTIVAL VOTING SYSTEM :::...<<<<");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("....:::: [FILM CODE] ::::..... ");
        Console.WriteLine("");
        Console.WriteLine(">>>[FILM NAME]<<<    >>>[VOTE NUMBER]<<<");
        Console.WriteLine("");
        Console.WriteLine("[THE GOD FATHER]   :-  [1]");
        Console.WriteLine("");
        Console.WriteLine("[TWILLIGHT]        :-  [2]");
        Console.WriteLine("");
        Console.WriteLine("[HARRY POTTER]     :-  [3]");
        Console.WriteLine("");
        Console.WriteLine("");
        do
        {
            Console.Write("Enter Your Vote [ RT <Drama Name> <Vote Number> ] : ");
            string vote = Console.ReadLine();
            if  (vote=="STOP" || vote=="stop")
            {
                stop_chk=true;
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("....:::: [RESULTS DISPLAYED AS FOLLOWS] ::::.....  ");
                Console.WriteLine("");
                Console.WriteLine("[THE GOD FATHER]   :-  [{0}]",tgf);
                Console.WriteLine("");
                Console.WriteLine("[TWILLIGHT]        :-  [{0}]",twl);
                Console.WriteLine("");
                Console.WriteLine("[HARRY POTTER]     :-  [{0}]",hrp);
                
            }else
            {
                stop_chk=false;
            }
            try
            {
            string[] split=vote.Split(" ");
            string voteNum = split[split.Length-1];
            int voteNumInt = Convert.ToInt32(voteNum);
            switch (voteNumInt)
        {
            case 1:
                    tgf++;
                    Console.WriteLine("Vote Succefully Added To [THE GOD FATHER]");
                    Console.WriteLine("");
                    break;
            case 2:
                    twl++;
                    Console.WriteLine("Vote Succefully Added To [TWILLIGHT]");
                    Console.WriteLine("");
                    break;
            case 3:
                    hrp++;
                    Console.WriteLine("Vote Succefully Added To [HARRY POTTER]");
                    Console.WriteLine("");
                    break; 
            default:
                    Console.WriteLine("Invalid Vote Please Re Enter!");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;      
        }
            }
            catch
            {
                Console.WriteLine("");
                Console.WriteLine(">>>...:::: Vote System Terminated! :::...<<<");
                
            }
        }while (stop_chk==false);

        
    }
}