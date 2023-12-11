using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            int npcs;
            NPCTraits[] traits;
            Classes[] classe;
            
            Console.WriteLine("Introduza o número de npc's: ");
            string nrNPC = Console.ReadLine();

            npcs = Convert.ToInt32(nrNPC);

            traits = new NPCTraits[npcs];
            classe = new Classes[npcs];
            
            for(int i = 0; i < npcs; i++)
            {
                for(int y = 0; y < Enum.GetValues(typeof(Classes)).Length; y++)
                {
                    Console.WriteLine($"NPC{i} é um {(Classes)y}? ");

                    string x = Console.ReadLine();

                    if(x == "Sim")
                    {
                       classe[i] = (Classes)y;

                       break; 
                    }
                }

                for(int u = 0; u < Enum.GetValues(typeof(NPCTraits)).Length; u++)
                {
                    Console.WriteLine($"NPC{i} tem {(NPCTraits)u}? ");

                    string t = Console.ReadLine();

                    if(t == "Sim")
                    {
                       traits[i] = (NPCTraits)u;
 
                        break;
                    }
                }

                Console.WriteLine($"NPC{i} é um {(classe[i])} e tem {(traits[i])}. ");
                Console.WriteLine();
            }

        }
    }
}
