/*
    KEY: 
        SP - Solarpunk [Story seed library]
        NGA - Classic painting [National gallary of art]
        Ink - Inktober
        fan - Fantassy inspired art
*/

//all pictures
using System.Drawing;

List<string> allPics = [
    "1. Solar Ascension (SP)",
    "2. Victory (SP)",
    "3. Solarpunk lab (SP)",
    "4. The floating village (SP)",
    "5. Earth collage - utopia 2048 (SP)",
    "6. How to build a solar punk city (SP)",
    "7. A harvester of knowledge (SP)",
    "8. Subak: water irrigation system (SP)",
    "9. Still Life with Artichokes and a parrot (NGA)",
    "10. Basilica constantine doric colonnade (NGA)",
    "11. Lady Cunliffe(NGA)",
    "12. View la cava (NGA)",
    "13. Queen henirietta maria sir jeffrey hudson (NGA)",
    "14. Philosopher (NGA)", 
    "15. Roses (NGA)",
    "16. Washington valley forge (NGA)", 
    "17. Ripe (Ink: holm)",
    "18. Troll attack (Ink: Higgins)", 
    "19. Bone (Ink: Hedge)",
    "20. Error (Ink: Birelmann)",
    "21. Holidays (Fan: P&C)",
    "22. Elijah the rainbow dream dragon (Fan:Kayas )", 
    "23. Slime girl (Fan: Remmade)",
    "24. Sara- manga Style (Fan: Lilou)", 
    "25. Concept game (Fan: Dadsky)",

    "AI.1. Solar Ascension ",
    "AI.2. Victory ",
    "AI.3. Solarpunk lab ",
    "AI.4. The floating village ",
    "AI.5. Earth collage - utopia 2048 ",
    "AI.6. How to build a solar punk city ",
    "AI.7. A harvester of knowledge ",
    "AI.8. Subak: water irrigation system ",
    "AI.9. Still Life with Artichokes and a parrot ",
    "AI.10. Basilica constantine doric colonnade ",
    "AI.11. Lady Cunliffe",
    "AI.12. View la cava ",
    "AI.13. Queen henirietta maria sir jeffrey hudson ",
    "AI.14. Philosopher ", 
    "AI.15. Roses ",
    "AI.16. Washington valley forge ", 
    "AI.17. Ripe ",
    "AI.18. Troll attack ", 
    "AI.19. Bone ",
    "AI.20. Error ",
    "AI.21. Holidays ",
    "AI.22. Elijah the rainbow dream dragon ", 
    "AI.23. Slime girl ",
    "AI.24. Sara - Manga Style", 
    "AI.25. Concept art Game",
];


//Console.WriteLine("Try: 9");
//Console.WriteLine(allPics.Count);


int countAllpics = allPics.Count;

Console.WriteLine("Randomly generated order");

/* for (var i = 0; i < countAllpics; i++)
{
    //Console.WriteLine(allPics[i]);
    
    int index = Random.Shared.Next(0, allPics.Count);
   // Console.WriteLine("This is the index for next picture " + index + " left " + allPics.Count);
    Console.WriteLine(allPics[index]);
    allPics.RemoveAt(index);
    //Console.WriteLine("this is how many left efter remove " + allPics.Count);
} */

int aiCount = 0; 
int humnaCount = 0; 
for (var i = 0; i < 40; i++)
{
    //Console.WriteLine(allPics[i]);
    Console.BackgroundColor = ConsoleColor.Black;
    int index = Random.Shared.Next(0, allPics.Count);
    // Console.WriteLine("This is the index for next picture " + index + " left " + allPics.Count);
    if (allPics[index].Contains("AI")){
        Console.ForegroundColor= ConsoleColor.Red;
        aiCount ++; 
    }
    else{
        Console.ForegroundColor = ConsoleColor.Blue;
        humnaCount ++; 
    }
    Console.WriteLine(allPics[index]);
    allPics.RemoveAt(index);
    //Console.WriteLine("this is how many left efter remove " + allPics.Count);
}
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Total pictures: {humnaCount +aiCount}. human: {humnaCount}, Ai: {aiCount}"); 

/* 
10. Basilica constantine doric colonnade (NGA)
21. Holidays (Fan: P&C)
9. Still Life with Artichokes and a parrot (NGA)
AI.19. Bone 
AI.23. Slime girl 
2. Victory (SP)
AI.24. Missing 1 human
AI.16. Washington valley forge 
3. Solarpunk lab (SP)
AI.20. Error 
22. Elijah the rainbow dream dragon (Fan:Kayas )
AI.2. Victory 
AI.6. How to build a solar punk city
15. Roses (NGA)
4. The floating village (SP)
AI.1. Solar Ascension
24. Missing 1 human(Fan: TBC)
16. Washington valley forge (NGA)
AI.12. View la cava
AI.3. Solarpunk lab
AI.8. Subak: water irrigation system
AI.11. Lady Cunliffe
7. A harvester of knowledge (SP)
AI.13. Queen henirietta maria sir jeffrey hudson
AI.9. Still Life with Artichokes and a parrot
AI.15. Roses
AI.5. Earth collage - utopia 2048
19. Bone (Ink: Hedge)
6. How to build a solar punk city (SP)
25. Missing 2 human(Fan: TBC)
5. Earth collage - utopia 2048 (SP)
AI.17. Ripe
17. Ripe (Ink: holm)
12. View la cava (NGA)
AI.25. Missing 2 human
23. Slime girl (Fan: Remmade)
8. Subak: water irrigation system (SP)
1. Solar Ascension (SP)
20. Error (Ink: Birelmann)
AI.10. Basilica constantine doric colonnade
11. Lady Cunliffe(NGA)
AI.14. Philosopher
AI.21. Holidays
AI.22. Elijah the rainbow dream dragon
AI.18. Troll attack
14. Philosopher (NGA)
AI.4. The floating village
18. Troll attack (Ink: Higgins)
AI.7. A harvester of knowledge
13. Queen henirietta maria sir jeffrey hudson (NGA) */


/* 
Randomly generated order
14. Philosopher (NGA)
15. Roses (NGA)
AI.6. How to build a solar punk city
1. Solar Ascension (SP)
19. Bone (Ink: Hedge)
AI.12. View la cava
2. Victory (SP)
AI.4. The floating village
16. Washington valley forge (NGA)
6. How to build a solar punk city (SP)
AI.14. Philosopher
AI.18. Troll attack
AI.9. Still Life with Artichokes and a parrot
AI.11. Lady Cunliffe
AI.5. Earth collage - utopia 2048
7. A harvester of knowledge (SP)
AI.10. Basilica constantine doric colonnade
3. Solarpunk lab (SP)
11. Lady Cunliffe(NGA)
12. View la cava (NGA)
18. Troll attack (Ink: Higgins)
AI.17. Ripe
AI.2. Victory
13. Queen henirietta maria sir jeffrey hudson (NGA)
AI.7. A harvester of knowledge
10. Basilica constantine doric colonnade (NGA)
AI.3. Solarpunk lab
AI.13. Queen henirietta maria sir jeffrey hudson
23. Slime girl (Fan: Remmade)
AI.8. Subak: water irrigation system
AI.16. Washington valley forge
AI.22. Elijah the rainbow dream dragon
24. Sara- manga Style (Fan: Lilou)
AI.25. Concept art Game
4. The floating village (SP)
8. Subak: water irrigation system (SP)
22. Elijah the rainbow dream dragon (Fan:Kayas )
AI.21. Holidays
AI.23. Slime girl
25. Concept game (Fan: Dadsky)
Total pictures: 40. human: 20, Ai: 20
 */