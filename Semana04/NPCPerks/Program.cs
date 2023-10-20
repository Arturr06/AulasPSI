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
            NPCTraits especial;
        
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

                for(int u = 1; u <= Enum.GetValues(typeof(NPCTraits)).Length; u++)
                {
                    int b = 1 << u-1;

                    Console.WriteLine($"NPC{i} tem {(NPCTraits)b}? ");

                    string t = Console.ReadLine();

                    if(t == "Sim")
                    {

                        traits[i] |= (NPCTraits)b;
 
                    }
                }

                Console.WriteLine($"NPC{i} é um {(classe[i])} e tem {(traits[i])}. ");
                
                especial = NPCTraits.Luck | NPCTraits.Charisma | NPCTraits.Strenght;

                if((traits[i]) == especial)
                {
                    Console.WriteLine("Combinação perfeita.");
                }
                
                Console.WriteLine();
            }

        }
    }
}
