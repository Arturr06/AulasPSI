using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            int npcs;
            NPCTraits especial;

            Classes[] classe;
            NPCTraits[] traits;


            Console.WriteLine("Introduza o número de npc's: ");
            string nrNPC = Console.ReadLine();

            npcs = Convert.ToInt32(nrNPC);

            classe = new Classes[npcs];
            traits = new NPCTraits[npcs]; 
            
            for(int i = 0; i < npcs; i++)
            {
                
                for(int y = 1; y <= Enum.GetValues(typeof(Classes)).Length; y++)
                {
                    classe[i] = MetClasses(y, i);

                    if(classe[i] != 0)
                    {
                        break;
                    }
                }

                for(int u = 1; u <= Enum.GetValues(typeof(NPCTraits)).Length; u++)
                {
                    traits[i] |= MetTraits(u, i);
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

        private static Classes MetClasses(int i, int j)
        {
            
            Classes classe = 0;

            Console.WriteLine($"NPC{j} é um {(Classes)i}? ");

            string x = Console.ReadLine();
    
            if(x == "Sim")
            {
                classe = (Classes)i;
            }

            return classe;
        }

        private static NPCTraits MetTraits(int i, int j)
        {
            NPCTraits traits = 0;
            
            int b = 1 << i-1;

            Console.WriteLine($"NPC{j} tem {(NPCTraits)b}? ");

            string t = Console.ReadLine();

            if(t == "Sim")
            {
                traits = (NPCTraits)b;
            }

            return traits;    
        }
    }
}
